using System;
using System.Collections.Generic;
using System.Text;


namespace RecursividadeAtividdade1.Recursao
{
    class RecursaoDecrescente
    {
        public string str_final = "Saída: ";

        public RecursaoDecrescente(int valor)
        {
            ValoresOrdemDecrescente(valor);
        }

        public void ValoresOrdemDecrescente(int valor)
        {
            if(valor > 0)
            {
                str_final += valor;
                valor--;
                if (valor > 0)
                {
                    str_final += ", ";
                    ValoresOrdemDecrescente(valor);
                }
            }
        }
    }
}
