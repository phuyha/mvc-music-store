namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateArtist : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Men At Work')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Aaron Copland & London Symphony Orchestra')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Aaron Goldberg')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'AC/DC')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Accept')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Adrian Leaper & Doreen de Feis')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Aerosmith')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Aisha Duo')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Alanis Morissette')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Alice In Chains')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Amy Winehouse')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Anita Ward')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Ant�nio Carlos Jobim')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Apocalyptica')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Audioslave')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Barry Wordsworth & BBC Concert Orchestra')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Berliner Philharmoniker & Hans Rosbaud')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Berliner Philharmoniker & Herbert Von Karajan')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Billy Cobham')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Black Label Society')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Black Sabbath')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Boston Symphony Orchestra & Seiji Ozawa')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Britten Sinfonia, Ivor Bolton & Lesley Garrett')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Bruce Dickinson')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Caetano Veloso')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Cake')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Calexico')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'C�ssia Eller')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Chic')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Chicago Symphony Orchestra & Fritz Reiner')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Chico Buarque')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Chico Science & Na��o Zumbi')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Chris Cornell')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Christopher O''Riley')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Cidade Negra')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Cl�udio Zoli')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Creedence Clearwater Revival')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'David Coverdale')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Deep Purple')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Dennis Chambers')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Djavan')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Donna Summer')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Dread Zeppelin')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Ed Motta')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Edo de Waart & San Francisco Symphony')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Elis Regina')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'English Concert & Trevor Pinnock')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Eric Clapton')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Eugene Ormandy')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Faith No More')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Falamansa')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Foo Fighters')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Frank Zappa & Captain Beefheart')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Funk Como Le Gusta')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Gilberto Gil')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Godsmack')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Gonzaguinha')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'G�teborgs Symfoniker & Neeme J�rvi')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Guns N'' Roses')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Incognito')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Iron Maiden')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'James Levine')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Jamiroquai')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Jimi Hendrix')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Joe Satriani')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Jorge Ben')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Jota Quest')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Judas Priest')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Kent Nagano and Orchestre de l''Op�ra de Lyon')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Kiss')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Led Zeppelin')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Legi�o Urbana')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Lenny Kravitz')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'London Symphony Orchestra & Sir Charles Mackerras')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Luciana Souza/Romero Lubambo')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Marcos Valle')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Marillion')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Marisa Monte')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Martin Roscoe')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Metallica')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Michael Tilson Thomas & San Francisco Symphony')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Miles Davis')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Milton Nascimento')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'M�tley Cr�e')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Mot�rhead')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Nash Ensemble')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Nicolaus Esterhazy Sinfonia')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Nirvana')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'O Ter�o')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Olodum')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Orchestra of The Age of Enlightenment')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Os Paralamas Do Sucesso')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Ozzy Osbourne')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Page & Plant')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Paul D''Ianno')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Pearl Jam')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Pink Floyd')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Queen')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'R.E.M.')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Raul Seixas')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Red Hot Chili Peppers')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Roger Norrington, London Classical Players')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Royal Philharmonic Orchestra & Sir Thomas Beecham')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Rush')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Santana')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Scholars Baroque Ensemble')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Sergei Prokofiev & Yuri Temirkanov')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Sir Georg Solti & Wiener Philharmoniker')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Skank')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Soundgarden')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Spyro Gyra')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Stevie Ray Vaughan & Double Trouble')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Stone Temple Pilots')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'System Of A Down')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Temple of the Dog')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Terry Bozzio, Tony Levin & Steve Stevens')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The  Cellists of The Berlin Philharmonic')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The Black Crowes')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'The Cult')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'The Doors')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The King''s Singers')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The Police')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The Posies')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The Rolling Stones')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'The Who')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Tim Maia')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Ton Koopman')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'U')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'UB')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES ( N'Van Halen')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Various Artists')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Velvet Revolver')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Vin�cius De Moraes')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Wilhelm Kempff')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Yehudi Menuhin')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Yo-Yo Ma')
                INSERT INTO [dbo].[Artists] ([Name]) VALUES (N'Zeca Pagodinho')
            ");
        }

        public override void Down()
        {
        }
    }
}
