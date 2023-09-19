using Ejercicio3.Componentes.BancoMemoria;
using Ejercicio3.Componentes.DiscoDuro;
using Ejercicio3.Componentes.DiscoMecanico;
using Ejercicio3.Componentes.ProcesadoreAMD;
using Ejercicio3.Componentes.ProcesadoresIntel;
using Ejercicio3.Interfaces;
using Ejercicio3.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class FactoriaOrdenadores : IOrdenadorInterface
    {
        public IGuardable DameGuardable(TipoGuardable miembro)
        {
            switch (miembro)
            {
                case TipoGuardable._789_XX: return new _789_XX();
                case TipoGuardable._789_XX_2: return new _789_XX_2();
                case TipoGuardable._789_XX_3: return new _789_XX_3();
                case TipoGuardable._788_fg: return new _788_fg();
                case TipoGuardable._788_fg2: return new _788_fg2();
                case TipoGuardable._788_fg3: return new _788_fg3();


                default: return new _788_fg3();

            }
        }

        public IMemorizable DameMemorizable(TipoMemorizable miembro)
        {
            switch (miembro)
            {

                case TipoMemorizable._879FH_L: return new _879FH_L();
                case TipoMemorizable._879FH: return new _879FH();
                case TipoMemorizable._879FH_T: return new _879FH_T();
                default: return new _879FH_T();

            }
        }
        public IProcesable DameProcesable(TipoProcesador miembro)
        {
            switch (miembro)
            {

                case TipoProcesador._789_XCD: return new _789_XCD();
                case TipoProcesador._789_XCT: return new _789_XCT();
                case TipoProcesador._789_XCS: return new _789_XCS();
                case TipoProcesador._797_X: return new _797_X();
                case TipoProcesador._797_X2: return new _797_X2();
                case TipoProcesador._797_X3: return new _797_X3();
                
                default: return new _797_X3();

            }
        }
    }
}
