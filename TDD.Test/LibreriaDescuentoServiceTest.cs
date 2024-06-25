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

            Assert.That(total, Is.EqualTo(10));
        }

        [Test]
        public void CalcularDescuentCaso02()
        {
            // calcular de 2 libros diferentes
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro());
            service.AddLibro(new Libro());

            var total = service.GetTotal();

            Assert.That(total, Is.EqualTo(20));
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

            Assert.That(total, Is.EqualTo(30));
        }

        [Test]
        public void CalcularDescuentCaso04()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 1 });
            
            var total = service.GetTotal();

            Assert.That(total, Is.EqualTo(19));
        }

        [Test]
        public void CalcularDescuentCaso05()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1 });
            service.AddLibro(new Libro { SagaId = 2 });

            var total = service.GetTotal();

            Assert.That(total, Is.EqualTo(20));
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

            Assert.That(total, Is.EqualTo(27));
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

            Assert.That(total, Is.EqualTo(38));
        }

        [Test]
        public void CalcularDescuentCaso08()
        {
            // calcular de 2 libros misma saga
            var service = new LibreriaDescuentoService();
            service.AddLibro(new Libro { SagaId = 1, LibroId = 1 });
            service.AddLibro(new Libro { SagaId = 1, LibroId = 1 });
            
            var total = service.GetTotal();

            Assert.That(total, Is.EqualTo(20));
        }
    }
}
