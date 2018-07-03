﻿using OfflineSync.Client.Models.SQLite;
using SQLite;

namespace User.FormsApp
{
    class tblTestTWS : ISQLiteSyncClientModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string VersionID { get; set; }
        public string TransactionID { get; set; }
        public bool? IsSynced { get; set; }
        public string SyncCreatedAt { get; set; }
        public string SyncModifiedAt { get; set; }
    }
}