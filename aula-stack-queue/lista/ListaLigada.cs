using System;
using System.Collections.Generic;

namespace aula.lista
{
    public class ListaLigada
    {
        public Vagao Trem { get; set; }

        public void InserirVagao(Vagao novoVagao) {
            if(Trem == null) Trem = novoVagao;
            else {
                var vagaoAnterior = getUltimoVagao();
                vagaoAnterior.VagaoAnterior = novoVagao;
            }
        }

        public Vagao getUltimoVagao() {
            var tempVagao = Trem;
            while(tempVagao.VagaoAnterior != null) {
                tempVagao = tempVagao.VagaoAnterior;
            }
            return tempVagao;
        }

        public Vagao? BuscarPorId(int id) {
            var tempVagao = Trem;
            while(tempVagao != null && tempVagao.Id != id) {
                tempVagao = tempVagao.VagaoAnterior;
            }
            return tempVagao;
        }

        public List<Vagao> BuscarPorCarga(string carga) {
            var tempVagao = Trem;
            List<Vagao> listVagao = new List<Vagao>();
            do{
                if(tempVagao.Carga == carga)
                    listVagao.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            } while(tempVagao != null);
            return listVagao;
        }

        public List<Vagao> BuscarPorPeso(int peso) {
            var tempVagao = Trem;
            List<Vagao> listVagao = new List<Vagao>();
            do{
                if(tempVagao.Peso == peso)
                    listVagao.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            } while(tempVagao != null);
            return listVagao;
        }

        public List<Vagao> getVagoes() {
            var _trem = new List<Vagao>();
            var tempVagao = Trem;
            while(tempVagao != null) {
                _trem.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            };
            return _trem;
        }
    }
}