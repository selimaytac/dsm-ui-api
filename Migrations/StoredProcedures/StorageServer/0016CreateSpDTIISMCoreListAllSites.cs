﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace DSM.UI.Api.Migrations.StoredProcedures.StorageServer
{

    [DbContext(typeof(DSMStorageDataContext))]
    [Migration("ZY0016-CreateSpDTIISMCoreListAllSites_StoredProcedure")]
    public class CreateSpDTIISMCoreListAllSites : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            string spCreateQuery = @"
-- =============================================
-- Author: Onur Akkaya
-- Create date: 19.03.2019
-- Description:	gets all sites from table
-- =============================================
CREATE PROCEDURE [dbo].[SP_DTIISMCore_ListAllSites]
AS
BEGIN
    SELECT 
        * 
    FROM 
        dbo.IISSite
END
";
            migrationBuilder.Sql(sql: spCreateQuery);
        }
    }
}
