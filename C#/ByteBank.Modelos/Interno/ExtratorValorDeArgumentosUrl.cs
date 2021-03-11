using System;
using System.Globalization;

namespace ByteBank.Modelos.Interno
{
    public class ExtratorValorDeArgumentosUrl
    {
        // Getters & Setters
        // public readonly string _arguments;
        
        // Construtor
        public ExtratorValorDeArgumentosUrl(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("A URL não pode ser vazia ou nula.", nameof(url));
            }
        }
    }
}