﻿using System.Diagnostics.CodeAnalysis;

namespace Kanini.InvestmentSearchEngine.StockValue.Models.Error
{
    [ExcludeFromCodeCoverage]
    public class Error
    {
        public int ErrorNumber { get; set; }
        public string? ErrorMessage { get; set; }
        public Error(int errorNumber, string errorMessage)
        {
            ErrorNumber = errorNumber;
            ErrorMessage = errorMessage;
        }
    }
}
