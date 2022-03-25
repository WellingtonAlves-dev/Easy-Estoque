using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Models
{
    internal class Produtos
    {
        private Int64 _id;
        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;
        public string Nome
        {
            get { return _nome.ToUpper(); }
            set
            {
                if(value != "")
                {
                    this._nome = value;
                } else
                {
                    throw new Exception("O nome não pode ser vázio");
                }
            }
        }
        private double _preco;
        public double Preco
        {
            get { return _preco; }
            set { _preco = Math.Round(value, 2); }
        }
        private string _img;
        public string Img
        {
            get { return _img; }
            set { _img = value; }
        }
    }
}
