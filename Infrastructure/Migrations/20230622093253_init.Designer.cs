﻿// <auto-generated />
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(StoryNameLinkContext))]
    [Migration("20230622093253_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.ModelEF.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "Once upon a time, in a magical land called Blazoria, there was a young girl named\r\nClara:\r\nShe lived in a cozy cottage deep within the enchanted forest.\r\nClara:\r\nhad a pet dragon named\r\nSparky:\r\nwho could breathe fire and fly through the sky.\r\nOne sunny morning,\r\nClara:\r\ndecided to go on an adventure with\r\nSparky:\r\nThey set out to explore the vast and mysterious forest, filled with talking animals and hidden treasures. As they journeyed deeper into the woods,\r\nClara:\r\nencountered a mischievous elf named\r\nOliver:\r\nOliver:\r\nwas known for his pranks and riddles. He loved to play tricks on unsuspecting travelers. \r\nClara: and \r\nSparky:\r\nwere intrigued by Oliver's playful nature and decided to befriend him. They spent hours laughing and sharing stories under the shade of a giant oak tree.\r\nAs time went by,\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nbecame the best of friends. They went on many exciting adventures together, discovering secret caves, solving puzzles, and helping those in need. People from all over Blazoria knew about their extraordinary friendship.\r\nOne day, a wicked sorceress named\r\nMorgana:\r\ncast a dark spell on the land, bringing chaos and despair. The once vibrant colors of Blazoria turned dull and lifeless.\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nknew they had to stop\r\nMorgana:\r\nand save their beloved land.\r\nWith their combined strengths and unwavering determination, \r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nembarked on a quest to find the legendary Sword of Light. Legend had it that only the chosen ones could wield its power and defeat\r\nMorgana:\r\nThey faced numerous challenges and overcame many obstacles along the way.\r\nFinally, after a perilous journey, \r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nreached the hidden chamber where the Sword of Light awaited them. With great courage, \r\nClara:\r\ngrasped the sword and felt its energy coursing through her veins. The trio set off to confront\r\nMorgana:\r\nready to restore peace to Blazoria.\r\nIn an epic battle,\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nfought against \r\nMorgana:\r\nand her minions. With each swing of the Sword of Light, their strength grew stronger, and the darkness began to recede. The people of Blazoria cheered as\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nemerged victorious, bringing light and hope back to their land.\r\nFrom that day forward,\r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nwere hailed as heroes throughout Blazoria. They continued to protect their magical land and create beautiful memories together. Their friendship and bravery inspired generations to come.\r\nAnd so, the story of \r\nClara:\r\nSparky:\r\nand\r\nOliver:\r\nthe fearless adventurers, became a legend that would be told for centuries in the enchanting realm of Blazoria."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
