







SELECT name, collation_name FROM sys.databases;
GO
ALTER DATABASE db_ab2679_arhitekturaweb SET SINGLE_USER WITH
ROLLBACK IMMEDIATE;
GO
ALTER DATABASE db_ab2679_arhitekturaweb COLLATE Croatian_CI_AS;
GO
ALTER DATABASE db_ab2679_arhitekturaweb SET MULTI_USER;
GO
SELECT name, collation_name FROM sys.databases;
GO



-- kreiram tablice
create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2) null, -- null se ne mora pisati
izvodiseod datetime,
vaucer bit
);

create table grupe(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
velicinagrupe int not null,
predavac varchar(50),
smjer int not null references smjerovi(sifra)
);

-- razlika varchar i char
-- varchar(10)
-- 'Ana'
-- char(10)
-- 'Ana       '

create table polaznici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100) not null,
oib char(11)
);

create table clanovi(
grupa int not null references grupe(sifra),
polaznik int not null references polaznici(sifra)
);


-- 1
insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('Web programiranje',1225.48,'2024-11-06 17:00',1);

insert into smjerovi(naziv, cijena, izvodiseod, vaucer)
values
-- 2
('Java programiranje',null,null,null),
-- 3
('Serviseri',800,'2020-01-01',0);


insert into grupe(naziv,velicinagrupe,smjer)
values
-- 1
('WP6',27,1),
-- 2
('WP5',27,1),
-- 3
('WP7',27,1),
-- 4
('JP17',11,3);



INSERT INTO polaznici (ime, prezime, email) VALUES 
('Marko', 'Radoš', 'rados.marko05@gmail.com'),
('Tena', 'Vuli?', 'tena.vulic@gmail.com'),
('Karlo', 'Bili?', 'karlo.bilic2003@gmail.com'),
('Tin', 'Pintari?', 'tin.pinta@gmail.com'),
('Zoran', 'Pokupi?', 'zoran.pokupic@gmail.com'),
('Matija', 'Pokupi?', 'matija.pokupic0712@gmail.com'),
('Marta', 'Došen', 'martagranat18@gmail.com'),
('Luka', 'Valenti?', 'lukavalentic.lv@gmail.com'),
('Adam', 'Šolti?', 'soltic@gmail.com'),
('Robert', 'Mateaši?', 'robert.mateasic@gmail.com'),
('Tanja', 'Janus', 'janustanja@gmail.com'),
('Andrej', 'Mjeda', 'andrej.mjeda@gmail.com'),
('Marina (Josip)', 'Turalija', 'marinamiochr@gmail.com'),
('Bernarda', 'Lusch', 'bernarda.lusch@gmail.com'),
('Boris', 'Horvat', 'bhorv4t@gmail.com'),
('Robert', 'Koki?', 'kokic2001@gmail.com'),
('Ivan', 'Grevinger', 'grevinger.ivan@gmail.com'),
('Marko', 'Grgi?', 'marko.grg97@gmail.com'),
('Pamela', 'Mandi?', 'pamelamandic46@gmail.com'),
('Darko', 'Azinovi?', 'darko.azinovic@gmail.com'),
('Dino', 'Dizdarevi?', 'dinodizdarevic2001@gmail.com'),
('Luka', 'Kordi?', 'kordic234@gmail.com'),
('Ivan', 'Režan', 'forexivanrezan@gmail.com'),
('Antonio', 'Simpf', 'antonijosimpf@gmail.com');

insert into clanovi (grupa, polaznik)
values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7)
,(1,8),(1,9),(1,10),(1,11),(1,12),(1,12),(1,14),(1,15)
,(1,16),(1,17),(1,18),(1,19),(1,20),(1,21),(1,22),(1,23)
,(1,24);