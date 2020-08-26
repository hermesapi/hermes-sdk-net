﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pluggy.SDK.Model
{

    public class Account
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("itemId")]
        public Guid ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("marketingName")]
        public string MarketingName { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [JsonProperty("currencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("accountType")]
        public AccountType Type { get; set; }

        [JsonProperty("accountSubtype")]
        public AccountSubtype Subtype { get; set; }

        [JsonProperty("creditData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CreditAccount CreditData { get; set; }

        [JsonProperty("bankData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BankAccount BankData { get; set; }

        [JsonProperty("transactions")]
        public ICollection<Transaction> Transactions { get; set; }

    }

    public class BankAccount
    {
        [JsonProperty("transferNumber")]
        public string TransferNumber { get; set; }

        [JsonProperty("closingBalance")]
        public double? ClosingBalance { get; set; }
    }

    public class CreditAccount
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("balanceCloseDate")]
        public DateTime? BalanceCloseDate { get; set; }

        [JsonProperty("balanceDueDate")]
        public DateTime? BalanceDueDate { get; set; }

        [JsonProperty("AvailableCreditLimit")]
        public double? AvailableCreditLimit { get; set; }

        [JsonProperty("balanceForeignCurrency")]
        public double? BalanceForeignCurrency { get; set; }

        [JsonProperty("minimumPayment")]
        public double? MinimumPayment { get; set; }

    }
}


