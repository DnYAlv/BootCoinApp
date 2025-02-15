﻿namespace BootCoinApp.Models
{
    public class HeaderTransactionAddCoinGroup
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public DateTime? Date { get; set; }
        public ICollection<DetailTransactionAddCoinGroup> DetailTransactionAddCoinGroups { get; set; }
    }
}
