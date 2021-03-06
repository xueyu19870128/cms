﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model41
{
    public partial class TableAdministratorsInRoles
    {
        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class TableAdministratorsInRoles
    {
        public const string OldTableName = "AdministratorsInRoles";

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict,
            ConvertValueDict = ConvertValueDict
        };

        private static readonly string NewTableName = DataProvider.AdministratorsInRolesDao.TableName;

        private static readonly List<TableColumn> NewColumns = DataProvider.AdministratorsInRolesDao.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict = null;

        private static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
