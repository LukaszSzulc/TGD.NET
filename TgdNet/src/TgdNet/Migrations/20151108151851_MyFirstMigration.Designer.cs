using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TgdNet.Model;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace TgdNet.Migrations
{
    [DbContext(typeof(ItemsContext))]
    partial class MyFirstMigration
    {
        public override string Id
        {
            get { return "20151108151851_MyFirstMigration"; }
        }

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta7-15540")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn);

            modelBuilder.Entity("TgdNet.Model.ItemModel", b =>
                {
                    b.Property<string>("Id");

                    b.Property<bool>("IsOnSale");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Key("Id");
                });
        }
    }
}
