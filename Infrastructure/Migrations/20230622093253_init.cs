﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Text" },
                values: new object[] { 1, "Once upon a time, in a magical land called Blazoria, there was a young girl named\r\nClara:\r\nShe lived in a cozy cottage deep within the enchanted forest.\r\nClara:\r\nhad a pet dragon named\r\nSparky:\r\nwho could breathe fire and fly through the sky.\r\nOne sunny morning,\r\nClara:\r\ndecided to go on an adventure with\r\nSparky:\r\nThey set out to explore the vast and mysterious forest, filled with talking animals and hidden treasures. As they journeyed deeper into the woods,\r\nClara:\r\nencountered a mischievous elf named\r\nOliver:\r\nOliver:\r\nwas known for his pranks and riddles. He loved to play tricks on unsuspecting travelers. \r\nClara: and \r\nSparky:\r\nwere intrigued by Oliver's playful nature and decided to befriend him. They spent hours laughing and sharing stories under the shade of a giant oak tree.\r\nAs time went by,\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nbecame the best of friends. They went on many exciting adventures together, discovering secret caves, solving puzzles, and helping those in need. People from all over Blazoria knew about their extraordinary friendship.\r\nOne day, a wicked sorceress named\r\nMorgana:\r\ncast a dark spell on the land, bringing chaos and despair. The once vibrant colors of Blazoria turned dull and lifeless.\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nknew they had to stop\r\nMorgana:\r\nand save their beloved land.\r\nWith their combined strengths and unwavering determination, \r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nembarked on a quest to find the legendary Sword of Light. Legend had it that only the chosen ones could wield its power and defeat\r\nMorgana:\r\nThey faced numerous challenges and overcame many obstacles along the way.\r\nFinally, after a perilous journey, \r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nreached the hidden chamber where the Sword of Light awaited them. With great courage, \r\nClara:\r\ngrasped the sword and felt its energy coursing through her veins. The trio set off to confront\r\nMorgana:\r\nready to restore peace to Blazoria.\r\nIn an epic battle,\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nfought against \r\nMorgana:\r\nand her minions. With each swing of the Sword of Light, their strength grew stronger, and the darkness began to recede. The people of Blazoria cheered as\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nemerged victorious, bringing light and hope back to their land.\r\nFrom that day forward,\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nwere hailed as heroes throughout Blazoria. They continued to protect their magical land and create beautiful memories together. Their friendship and bravery inspired generations to come.\r\nAnd so, the story of \r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nthe fearless adventurers, became a legend that would be told for centuries in the enchanting realm of Blazoria." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
