using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.App
{
    public class LibreriaDescuentoService
    {
        private readonly List<Libro> Libros = new List<Libro>();

        public void AddLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public Decimal GetTotal()
        {
            decimal total = 0;
            var grupos = Libros.GroupBy(o => o.SagaId);
            foreach (var grupo in grupos) {
                var noNullSagas = grupo.Where(o => o.SagaId != null);
                if (noNullSagas.Count() == 2)
                {
                    total += 19m;
                }
                else if (noNullSagas.Count() == 3)
                {
                    total += 27m;
                }
                else {
                    total += grupo.Count() * 10;
                }
            }



            return total;
        }
    }
}
