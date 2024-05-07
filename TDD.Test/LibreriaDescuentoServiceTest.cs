using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.App;

namespace TDD.Test
{
    public class LibreriaDescuentoServiceTest
    {
        [Test]
        public void CalcularDescuentoCaso01()
        {
            // calcular de 1 libros
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro());


            var total = service.GetTotal();

            Assert.AreEqual(10, total);
        }

        [Test]
        public void CalcularDescuentCaso02()
        {
            // calcular de 2 libros diferentes
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro());
            service.AddLibro(new Libro());

            var total = service.GetTotal();

            Assert.AreEqual(20, total);
        }

        [Test]
        public void CalcularDescuentCaso03()
        {
            // calcular de 3 libros diferentes
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro());
            service.AddLibro(new Libro());
            service.AddLibro(new Libro());

            var total = service.GetTotal();

            Assert.AreEqual(30, total);
        }

        [Test]
        public void CalcularDescuentCaso04()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 1 });
            
            var total = service.GetTotal();

            Assert.AreEqual(19, total);
        }

        [Test]
        public void CalcularDescuentCaso05()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 2 });

            var total = service.GetTotal();

            Assert.AreEqual(20, total);
        }

        [Test]
        public void CalcularDescuentCaso06()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 1 });

            var total = service.GetTotal();

            Assert.AreEqual(27, total);
        }

        [Test]
        public void CalcularDescuentCaso07()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 2 });
            service.AddLibro(new Libro { SagaId = 2 });

            var total = service.GetTotal();

            Assert.AreEqual(38, total);
        }

        [Test]
        public void CalcularDescuentCaso08()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1, LibroId = 1 });
            service.AddLibro(new Libro { SagaId = 1, LibroId = 1 });
            
            var total = service.GetTotal();

            Assert.AreEqual(20, total);
        }
    }
}
