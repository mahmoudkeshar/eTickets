using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class logo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "You can watch all types of movies including horror.\n     They typically have multiple screens and show a wide variety of films.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Independent cinemas, \n      tucked in local neighborhoods, \n      curate diverse films beyond blockbusters, \n     fostering community and showcasing thought-provoking cinema.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "IMAX theaters are known for their large screens and immersive sound systems, \n    making them ideal for action-packed movies.'");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Some cinemas specialize in specific genres or types of films,\n     such as comedy clubs for comedy movies and art-house theaters for indie and foreign films.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Movies like 'Toy Story' are popular choices for children's cinemas,\n     which cater to families and young audiences with kid-friendly amenities and activities.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Drive-in cinemas offer a nostalgic outdoor movie-watching experience,\n    ideal for enjoying films comfortably from your car.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "Tom Hardy, an English actor renowned for his versatility, \n     captivates audiences with his intense performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Biography",
                value: "Jonah Hill is an American actor acclaimed for comedic brilliance,' \n    seamlessly transitioning to riveting dramatic roles '");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Biography",
                value: "Michael Cera is a Canadian actor known for his endearing awkwardness and comedic timing, \n     harming audiences in films.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Biography",
                value: "Tim Robbins is an American actor recognized for his roles \n    in 'The Shawshank Redemption' and 'Mystic River,'showcasing his versatility and depth as a performer.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Biography",
                value: "Morgan Freeman is an iconic American actor known for his authoritative presence \n    and memorable performances in films.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Biography",
                value: "Tom Hanks is an iconic American actor celebrated for his versatility \n    and captivating performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Biography",
                value: "Jack Nicholson is a legendary American actor known for his iconic roles \n   ,'captivating audiences with his intense performances and unique on-screen presence.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Biography",
                value: "Christian Bale, a British actor, embodies characters with remarkable intensity and commitment, \n     showcasing his range from iconic superhero roles to complex, psychologically rich performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Biography",
                value: "Bradley Cooper is an American actor known for his versatility, \n    starring in acclaimed films ,");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Biography",
                value: "Ed Helms, an American actor, is celebrated for his comedic talent, portraying Stu in 'The Hangover' \n     trilogy and Andy Bernard in 'The Office,'showcasing his versatile and humorous performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Biography",
                value: "Zach Galifianakis is an American actor known for his eccentric comedic style, \n    particularly in films.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Biography",
                value: " Fred Rogers, his gentle demeanor and compassionate spirit enriched the hearts of viewers \n    through 'Mister Rogers' Neighborhood,' fostering kindness and empathy in generations of children and adults alike.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Mad Max:Fury Road is an intense action film set in a post-apocalyptic world, \n         where a reluctant hero and a fierce warrior rebel against a tyrannical ruler in a high-octane battle for survival.", new DateTime(2024, 10, 14, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6033), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Superbad is a hilarious coming-of-age comedy film about two high school friends\n     on a wild adventure to secure alcohol for a party, leading to outrageous antics and unexpected challenges.", new DateTime(2024, 10, 18, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Shawshank Redemption follows Andy Dufresne, a banker wrongfully convicted of murder,\n    as he navigates prison life, finding solace and redemption through perseverance and friendship.", new DateTime(2024, 12, 3, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6048), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "March of the Penguins is a captivating documentary showcasing the journey of emperor penguins in the Antarctic,\n    revealing their resilience and determination in extreme conditions.", new DateTime(2024, 11, 13, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6054), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Toy Story is a heartwarming animated adventure film following the journey \n    of toys led by Woody and Buzz Lightyear.", new DateTime(2024, 11, 23, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6059), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Shining is a psychological horror film directed by Stanley Kubrick, \n    adapted from Stephen King's novel.", new DateTime(2024, 11, 11, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6065), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Dark Knight is a thrilling superhero epic pitting Batman against the Joker,\n    featuring Heath Ledger's iconic portrayal.", new DateTime(2024, 10, 24, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Hangover is a raucous comedy following a wild bachelor party in Las Vegas,\n     as the groomsmen attempt to piece together the events of the night before.", new DateTime(2024, 10, 31, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Forrest Gump is a heartwarming tale following the remarkable life of Forrest Gump, \n    a simple yet extraordinary man who unwittingly finds himself at the center of key moments in American history.", new DateTime(2024, 10, 13, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6082), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Won't You Be My Neighbor? is a heartfelt documentary exploring Fred Rogers' legacy,\n    celebrating his message of kindness and empathy in \"Mister Rogers' Neighborhood.", new DateTime(2024, 11, 3, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6088), new DateTime(2024, 10, 6, 21, 23, 40, 4, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "\n        <p>This Privacy Policy outlines how eTicket Movies collects, uses, maintains, and protects personal identification information obtained from users during the purchase of movie tickets and related services on our website.</p>\n\n        <h3>Collection of Personal Identification Information:</h3>\n\n        <p>We may collect personal identification information from users in various ways, including but not limited to, when users visit our site, register on the site, place an order, subscribe to the newsletter, respond to a survey, fill out a form, and in connection with other activities, services, features, or resources we make available on our site. Users may be asked for, as appropriate, name, email address, mailing address, phone number, and credit card information.</p>\n\n        <h3>Use of Personal Identification Information:</h3>\n\n        <p>We collect and use users' personal information for the following purposes:</p>\n        <ul>\n            <li><strong>To process transactions:</strong> We may use the information users provide about themselves when placing an order only to provide service to that order. We do not share this information with outside parties except to the extent necessary to provide the service.</li>\n            <li><strong>To send periodic emails:</strong> We may use the email address to send users information and updates pertaining to their order. It may also be used to respond to their inquiries, questions, and/or other requests. If users decide to opt-in to our mailing list, they will receive emails that may include company news, updates, etc. If at any time the user would like to unsubscribe from receiving future emails, we include detailed unsubscribe instructions at the bottom of each email.</li>\n        </ul>\n\n        <h3>Protection of Personal Identification Information:</h3>\n\n        <p>We adopt appropriate data collection and processing practices and security measures to protect against unauthorized access, alteration, disclosure, or destruction of users' personal information, username, password, transaction information, and data stored on our site.</p>\n    ");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "George Miller  is an Australian filmmaker celebrated for directing the groundbreaking \n    'Mad Max' series, showcasing his visionary storytelling and influence in the action genre.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Biography",
                value: "Judd Apatow is an American filmmaker known for his comedic genius, directing \n    and producing hit comedies.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Biography",
                value: "Niki Marvin, a film producer, has garnered acclaim for her work,\n    demonstrating a keen eye for talent and a commitment to bringing compelling stories to the screen.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Biography",
                value: "Luc Jacquet is a French filmmaker acclaimed for his captivating nature documentaries, notably the \n    Academy Award-winning 'March of the Penguins.'");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Biography",
                value: "Pixar Animation Studios is a renowned animation studio celebrated for its revolutionary storytelling \n    and groundbreaking computer-animated films, captivating audiences worldwide with its imaginative and heartfelt storytelling.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Biography",
                value: "Stanley Kubrick was a visionary filmmaker renowned for his meticulous attention to detail and profound \n    storytelling, creating cinematic masterpieces .");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Biography",
                value: "Christopher Nolan is a visionary filmmaker celebrated for his innovative storytelling and captivating \n    narratives, directing iconic films .");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Biography",
                value: "Todd Phillips, a filmmaker known for his edgy comedies,\n    rose to prominence with 'The Hangover' trilogy,\n    showcasing his unique blend of humor and storytelling prowess.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Biography",
                value: "Wendy Finerman, a renowned film producer, \n    has earned accolades for her exceptional storytelling and her ability to bring compelling narratives to life on the big screen.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Biography",
                value: "Morgan Neville, a renowned documentary filmmaker, captures the essence of his subjects,\n    crafting compelling narratives that resonate globally.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logos");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "You can watch all types of movies including horror.\r\n     They typically have multiple screens and show a wide variety of films.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Independent cinemas, \r\n      tucked in local neighborhoods, \r\n      curate diverse films beyond blockbusters, \r\n     fostering community and showcasing thought-provoking cinema.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "IMAX theaters are known for their large screens and immersive sound systems, \r\n    making them ideal for action-packed movies.'");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Some cinemas specialize in specific genres or types of films,\r\n     such as comedy clubs for comedy movies and art-house theaters for indie and foreign films.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Movies like 'Toy Story' are popular choices for children's cinemas,\r\n     which cater to families and young audiences with kid-friendly amenities and activities.");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Drive-in cinemas offer a nostalgic outdoor movie-watching experience,\r\n    ideal for enjoying films comfortably from your car.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "Tom Hardy, an English actor renowned for his versatility, \r\n     captivates audiences with his intense performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Biography",
                value: "Jonah Hill is an American actor acclaimed for comedic brilliance,' \r\n    seamlessly transitioning to riveting dramatic roles '");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Biography",
                value: "Michael Cera is a Canadian actor known for his endearing awkwardness and comedic timing, \r\n     harming audiences in films.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Biography",
                value: "Tim Robbins is an American actor recognized for his roles \r\n    in 'The Shawshank Redemption' and 'Mystic River,'showcasing his versatility and depth as a performer.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Biography",
                value: "Morgan Freeman is an iconic American actor known for his authoritative presence \r\n    and memorable performances in films.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Biography",
                value: "Tom Hanks is an iconic American actor celebrated for his versatility \r\n    and captivating performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Biography",
                value: "Jack Nicholson is a legendary American actor known for his iconic roles \r\n   ,'captivating audiences with his intense performances and unique on-screen presence.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Biography",
                value: "Christian Bale, a British actor, embodies characters with remarkable intensity and commitment, \r\n     showcasing his range from iconic superhero roles to complex, psychologically rich performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Biography",
                value: "Bradley Cooper is an American actor known for his versatility, \r\n    starring in acclaimed films ,");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Biography",
                value: "Ed Helms, an American actor, is celebrated for his comedic talent, portraying Stu in 'The Hangover' \r\n     trilogy and Andy Bernard in 'The Office,'showcasing his versatile and humorous performances.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Biography",
                value: "Zach Galifianakis is an American actor known for his eccentric comedic style, \r\n    particularly in films.");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Biography",
                value: " Fred Rogers, his gentle demeanor and compassionate spirit enriched the hearts of viewers \r\n    through 'Mister Rogers' Neighborhood,' fostering kindness and empathy in generations of children and adults alike.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Mad Max:Fury Road is an intense action film set in a post-apocalyptic world, \r\n         where a reluctant hero and a fierce warrior rebel against a tyrannical ruler in a high-octane battle for survival.", new DateTime(2024, 4, 28, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4899), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Superbad is a hilarious coming-of-age comedy film about two high school friends\r\n     on a wild adventure to secure alcohol for a party, leading to outrageous antics and unexpected challenges.", new DateTime(2024, 5, 2, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Shawshank Redemption follows Andy Dufresne, a banker wrongfully convicted of murder,\r\n    as he navigates prison life, finding solace and redemption through perseverance and friendship.", new DateTime(2024, 6, 17, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "March of the Penguins is a captivating documentary showcasing the journey of emperor penguins in the Antarctic,\r\n    revealing their resilience and determination in extreme conditions.", new DateTime(2024, 5, 28, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Toy Story is a heartwarming animated adventure film following the journey \r\n    of toys led by Woody and Buzz Lightyear.", new DateTime(2024, 6, 7, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Shining is a psychological horror film directed by Stanley Kubrick, \r\n    adapted from Stephen King's novel.", new DateTime(2024, 5, 26, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Dark Knight is a thrilling superhero epic pitting Batman against the Joker,\r\n    featuring Heath Ledger's iconic portrayal.", new DateTime(2024, 5, 8, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "The Hangover is a raucous comedy following a wild bachelor party in Las Vegas,\r\n     as the groomsmen attempt to piece together the events of the night before.", new DateTime(2024, 5, 15, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Forrest Gump is a heartwarming tale following the remarkable life of Forrest Gump, \r\n    a simple yet extraordinary man who unwittingly finds himself at the center of key moments in American history.", new DateTime(2024, 4, 27, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Won't You Be My Neighbor? is a heartfelt documentary exploring Fred Rogers' legacy,\r\n    celebrating his message of kindness and empathy in \"Mister Rogers' Neighborhood.", new DateTime(2024, 5, 18, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "\r\n        <p>This Privacy Policy outlines how eTicket Movies collects, uses, maintains, and protects personal identification information obtained from users during the purchase of movie tickets and related services on our website.</p>\r\n\r\n        <h3>Collection of Personal Identification Information:</h3>\r\n\r\n        <p>We may collect personal identification information from users in various ways, including but not limited to, when users visit our site, register on the site, place an order, subscribe to the newsletter, respond to a survey, fill out a form, and in connection with other activities, services, features, or resources we make available on our site. Users may be asked for, as appropriate, name, email address, mailing address, phone number, and credit card information.</p>\r\n\r\n        <h3>Use of Personal Identification Information:</h3>\r\n\r\n        <p>We collect and use users' personal information for the following purposes:</p>\r\n        <ul>\r\n            <li><strong>To process transactions:</strong> We may use the information users provide about themselves when placing an order only to provide service to that order. We do not share this information with outside parties except to the extent necessary to provide the service.</li>\r\n            <li><strong>To send periodic emails:</strong> We may use the email address to send users information and updates pertaining to their order. It may also be used to respond to their inquiries, questions, and/or other requests. If users decide to opt-in to our mailing list, they will receive emails that may include company news, updates, etc. If at any time the user would like to unsubscribe from receiving future emails, we include detailed unsubscribe instructions at the bottom of each email.</li>\r\n        </ul>\r\n\r\n        <h3>Protection of Personal Identification Information:</h3>\r\n\r\n        <p>We adopt appropriate data collection and processing practices and security measures to protect against unauthorized access, alteration, disclosure, or destruction of users' personal information, username, password, transaction information, and data stored on our site.</p>\r\n    ");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "George Miller  is an Australian filmmaker celebrated for directing the groundbreaking \r\n    'Mad Max' series, showcasing his visionary storytelling and influence in the action genre.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Biography",
                value: "Judd Apatow is an American filmmaker known for his comedic genius, directing \r\n    and producing hit comedies.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Biography",
                value: "Niki Marvin, a film producer, has garnered acclaim for her work,\r\n    demonstrating a keen eye for talent and a commitment to bringing compelling stories to the screen.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Biography",
                value: "Luc Jacquet is a French filmmaker acclaimed for his captivating nature documentaries, notably the \r\n    Academy Award-winning 'March of the Penguins.'");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Biography",
                value: "Pixar Animation Studios is a renowned animation studio celebrated for its revolutionary storytelling \r\n    and groundbreaking computer-animated films, captivating audiences worldwide with its imaginative and heartfelt storytelling.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Biography",
                value: "Stanley Kubrick was a visionary filmmaker renowned for his meticulous attention to detail and profound \r\n    storytelling, creating cinematic masterpieces .");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Biography",
                value: "Christopher Nolan is a visionary filmmaker celebrated for his innovative storytelling and captivating \r\n    narratives, directing iconic films .");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Biography",
                value: "Todd Phillips, a filmmaker known for his edgy comedies,\r\n    rose to prominence with 'The Hangover' trilogy,\r\n    showcasing his unique blend of humor and storytelling prowess.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Biography",
                value: "Wendy Finerman, a renowned film producer, \r\n    has earned accolades for her exceptional storytelling and her ability to bring compelling narratives to life on the big screen.");

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Biography",
                value: "Morgan Neville, a renowned documentary filmmaker, captures the essence of his subjects,\r\n    crafting compelling narratives that resonate globally.");
        }
    }
}
