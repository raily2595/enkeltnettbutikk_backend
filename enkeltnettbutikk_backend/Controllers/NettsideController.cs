using enkeltnettbutikk_backend.Context;
using enkeltnettbutikk_backend.Database_klasser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enkeltnettbutikk_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NettsideController : ControllerBase
    {
        private readonly NettbutikkDbContext _context;

        public NettsideController (NettbutikkDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<NettsideOrdre>> CreateOrder([FromBody] Bestillingsforespørsel orderRequest)
        {
            if (orderRequest == null || orderRequest.Produkter == null || orderRequest.Produkter.Count == 0)
            {
                return BadRequest("Invalid order data");
            }

            // Opprett en ny ordre fra bestillingsforespørselen
            var order = new NettsideOrdre
            {
                Navn = orderRequest.Navn,
                Epost = orderRequest.Epost,
                Adresse = orderRequest.Adresse,
                Postnr = orderRequest.Postnr,
                Poststed = orderRequest.Poststed,
                Telefon = orderRequest.Telefon,
                Betalingsmetode = orderRequest.Betalingsmetode,
                Betalingsstatus = orderRequest.Betalingsstatus,
                OrdreDato = DateTime.Now,
                Produkter = new List<Produkt>(),
                Totalt = orderRequest.Totalt,
                Bestillingsstatus = orderRequest.Bestillingsstatus
            };

            foreach (var productRequest in orderRequest.Produkter)
            {
                // Opprett produktobjekter og legg til i ordren
                var product = new Produkt
                {
                    Produktnavn =  productRequest.Produktnavn,
                    KategoriNavn = productRequest.KategoriNavn,
                    Farge = productRequest.Farge,
                    Farge2 = productRequest.Farge2,
                    Lengde = productRequest.Lengde,
                    Bredde = productRequest.Bredde,
                    Detaljefarger = productRequest.Detaljefarger,
                    Klips = productRequest.Klips,
                    Vinyltekst = productRequest.Vinyltekst,
                    Fontfarge = productRequest.Fontfarge,
                    Font = productRequest.Font,
                    Pris = productRequest.Pris
                };

                order.Produkter.Add(product);
            }

            // Legg til ordren i konteksten og lagre i databasen
            _context.NettsideOrdrer.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrdreID }, order);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NettsideOrdre>> GetOrderById(int id)
        {
            var order = await _context.NettsideOrdrer.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // Legg til flere metoder etter behov (for oppdatering, sletting, henting av alle ordrer osv.)

        // ...
    }
}