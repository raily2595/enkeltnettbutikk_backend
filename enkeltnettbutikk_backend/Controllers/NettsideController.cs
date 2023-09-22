using enkeltnettbutikk_backend.Context;
using enkeltnettbutikk_backend.Database_klasser;
using Microsoft.AspNetCore.Mvc;

namespace enkeltnettbutikk_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NettsideController : ControllerBase
    {
        private readonly NettbutikkDbContext _context;

        public NettsideController(NettbutikkDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<Bestilling>> CreateOrder([FromBody] Bestillingsforespørsel orderRequest)
        {
            if (orderRequest == null || orderRequest.Produkter == null || orderRequest.Produkter.Count == 0)
            {
                return BadRequest("Ugyldig ordre data");
            }

            var kunde = new Kunde
            {
                KundeID = Guid.NewGuid().ToString(),
                Navn = orderRequest.Navn,
                Postnr = orderRequest.Postnr,
                Poststed = orderRequest.Poststed,
                Adresse = orderRequest.Adresse,
                Telefon = orderRequest.Telefon,
                Epost = orderRequest.Epost,
            };
            _context.Kunde.Add(kunde);
            await _context.SaveChangesAsync();

            var bestilling = new Bestilling
            {
                OrdreID = Guid.NewGuid().ToString(),
                KundeID = kunde.KundeID,
                OrdreDato = DateTime.Now,
                Bestillingsstatus = "motatt",
            };
            _context.Bestilling.Add(bestilling);
            await _context.SaveChangesAsync();

            foreach (var productRequest in orderRequest.Produkter)
            {
                var produkt = new Produkt
                {
                    ProduktID = Guid.NewGuid().ToString(),
                    Produktnavn = productRequest.Produktnavn,
                    Farge = productRequest.Farge,
                    Farge2 = productRequest.Farge2,
                    Lengde = productRequest.Lengde,
                    Bredde = productRequest.Bredde,
                    Detaljefarger = productRequest.Detaljefarger,
                    Klips = productRequest.Klips,
                    Vinyltekst = productRequest.Vinyltekst,
                    Fontfarge = productRequest.Fontfarge,
                    Font = productRequest.Font,
                    Pris = productRequest.Pris,
                };
                _context.Produkt.Add(produkt);
                await _context.SaveChangesAsync();

                var bestillingsdetalj = new Bestillingsdetalj
                {
                    BestillingsdetaljeID = Guid.NewGuid().ToString(),
                    OrdreID = bestilling.OrdreID,
                    ProduktID = produkt.ProduktID,
                    Delsum = produkt.Pris,
                };
                _context.Bestillingsdetalj.Add(bestillingsdetalj);
                await _context.SaveChangesAsync();
            }

            var transaksjon = new Transaksjon
            {
                TransaksjonsID = Guid.NewGuid().ToString(),
                OrdreID = bestilling.OrdreID,
                Betalingsmetode = orderRequest.Betalingsmetode,
                Betalingsstatus = "ikke betalt",
                Totalt = orderRequest.Totalt,
            };
            _context.Transaksjon.Add(transaksjon);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderById), new { ordreID = bestilling.OrdreID }, bestilling);
        }

        [HttpGet("{ordreID}")]
        public async Task<ActionResult<Bestilling>> GetOrderById(int ordreID)
        {
            return await _context.Bestilling.FindAsync(ordreID) is Bestilling bestilling ? Ok(bestilling) : NotFound();
        }

        // Legg til flere metoder etter behov (for oppdatering, sletting, henting av alle ordrer osv.)

        // ...
    }
}