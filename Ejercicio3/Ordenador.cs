using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3
{
    public class Ordenador
    {
        public int precioTotal;
        public int coresTotal;
        public int gradosTotal;
        public double almacenamientoguardableTotal;
        public double almacenamientomemorizableTotal;

        public List<IGuardable> listIGuardable = new List<IGuardable>();


        public void addIGuardable(IGuardable componente)
        {
            if(componente.getCantidad() >= 1) {
                componente.setCantidad(-1);
                precioTotal += componente.getPrecio();
                almacenamientoguardableTotal += componente.getAlmacenamiento();
                gradosTotal += componente.getCalor();
                listIGuardable.Add(componente);
            }
            else
            {
                Console.WriteLine("No hay cantidad suficiente del componenete: " + componente.getNSerie()) ;
            }
            
        }

        public List<IProcesable> listIcomponente = new List<IProcesable>();

        public void addIProcesable(IProcesable componente)
        {
            precioTotal += componente.getPrecio();
            coresTotal += componente.getCores();
            gradosTotal += componente.getCalor();
            listIcomponente.Add(componente);
        }

        public List<IMemorizable> listIMemorizable = new List<IMemorizable>();

        public void addIMemorizable(IMemorizable componente)
        {
            precioTotal += componente.getPrecio();
            almacenamientoguardableTotal += componente.getAlmacenamiento();
            gradosTotal += componente.getCalor();
            listIMemorizable.Add(componente);
        }


    }
}
