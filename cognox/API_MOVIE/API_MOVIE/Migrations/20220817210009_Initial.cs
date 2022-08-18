using Microsoft.EntityFrameworkCore.Migrations;

namespace API_MOVIE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Descripcion", "Titulo", "Url" },
                values: new object[] { 1, " Pelicula nro 1 de la cartelera", "12 años de esclavitud", "https://imagenes.canalrcn.com/lomaslike/preprate-para-conocer-los-12-aos-de-esclavitud-de-solomon-por-el-canal-rcn-este-domingo.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Descripcion", "Titulo", "Url" },
                values: new object[] { 2, " Pelicula nro 2 de la cartelera", "Dos buenos tipos", "https://pics.filmaffinity.com/Dos_buenos_tipos-118256026-large.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Descripcion", "Titulo", "Url" },
                values: new object[] { 3, "Auxilio abuela me pico una araña", "Spiderman 2", "https://static.wikia.nocookie.net/blackcoffe/images/1/1f/Spiderman2.jpg/revision/latest?cb=20120611025348&path-prefix=es" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
