using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SEPPokemon.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbilityHidden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbilityOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbilityTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvolutionNo = table.Column<int>(type: "int", nullable: false),
                    EvolutionPathsTotal = table.Column<int>(type: "int", nullable: false),
                    EvolutionPosNo = table.Column<int>(type: "int", nullable: false),
                    EvoultionPathsNo = table.Column<int>(type: "int", nullable: false),
                    GenderFemale = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    GenderMale = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokemonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
