-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 13, 2022 at 06:40 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db3`
--

-- --------------------------------------------------------

--
-- Table structure for table `architektas`
--

CREATE TABLE `architektas` (
  `ID` int(10) NOT NULL,
  `Vardas` varchar(20) NOT NULL,
  `Pavarde` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `architektas`
--

INSERT INTO `architektas` (`ID`, `Vardas`, `Pavarde`) VALUES
(1, 'Sigitas', 'Gintaris'),
(2, 'Petras', 'Jaunas'),
(3, 'Jonas', 'Zaibas'),
(4, 'Obama', 'Bin'),
(5, 'John', 'Cook'),
(6, 'Sugga', 'BTS'),
(7, 'DaBaby', 'Capsas'),
(8, 'Dainius', 'Savulionis');

-- --------------------------------------------------------

--
-- Table structure for table `bokstas`
--

CREATE TABLE `bokstas` (
  `ID` int(11) NOT NULL,
  `Ekskursija_ID` int(11) NOT NULL,
  `Pavadinimas` varchar(11) NOT NULL,
  `Aukstis` float NOT NULL,
  `Kaina` float NOT NULL,
  `Aukstis_virs_juros_lygio` float NOT NULL,
  `Pastatymo_data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bokstas`
--

INSERT INTO `bokstas` (`ID`, `Ekskursija_ID`, `Pavadinimas`, `Aukstis`, `Kaina`, `Aukstis_virs_juros_lygio`, `Pastatymo_data`) VALUES
(1, 21, 'Tauro ', 89.4, 2, 111, '2002-05-04'),
(4, 24, 'Vycio', 232, 1, 424, '2012-05-04'),
(5, 26, 'Eifelio', 301, 10, 324, '1889-02-10'),
(6, 25, 'ENZO', 231, 5, 245, '2002-04-10'),
(7, 27, '43 Butas', 25, 2, 25, '2012-04-25'),
(8, 22, 'Bezos', 178, 4, 190, '2000-08-29'),
(9, 23, 'Otulo', 97, 2, 101, '1990-12-24');

-- --------------------------------------------------------

--
-- Table structure for table `boksto_architektai`
--

CREATE TABLE `boksto_architektai` (
  `ID` int(10) NOT NULL,
  `Bokstas_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `boksto_architektai`
--

INSERT INTO `boksto_architektai` (`ID`, `Bokstas_ID`) VALUES
(2, 1),
(1, 4),
(7, 5),
(3, 7),
(5, 8),
(6, 9);

-- --------------------------------------------------------

--
-- Table structure for table `dangos_tipas`
--

CREATE TABLE `dangos_tipas` (
  `ID` int(10) NOT NULL,
  `Pavadinimas` varchar(20) NOT NULL,
  `Apibudinimas` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dangos_tipas`
--

INSERT INTO `dangos_tipas` (`ID`, `Pavadinimas`, `Apibudinimas`) VALUES
(3, 'Biri', 'Zvyras'),
(4, 'Takelis', 'Plyteles'),
(5, 'Medinis takas', 'Medinis'),
(6, 'Kelias', 'Asfaltas'),
(7, 'Misko takelis', 'zeme'),
(8, 'Pavojinga', 'Kalnai'),
(9, 'Paprasta', 'Akmenys');

-- --------------------------------------------------------

--
-- Table structure for table `ekskursijos`
--

CREATE TABLE `ekskursijos` (
  `ID` int(10) NOT NULL,
  `Gidas_ID` int(10) NOT NULL,
  `Miestas_ID` int(10) NOT NULL,
  `Kaina` float NOT NULL,
  `Laikas` datetime NOT NULL,
  `Aprasymas` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ekskursijos`
--

INSERT INTO `ekskursijos` (`ID`, `Gidas_ID`, `Miestas_ID`, `Kaina`, `Laikas`, `Aprasymas`) VALUES
(21, 4, 2, 15, '2022-05-09 22:02:02', 'Ekskursija Vilniuje lorem ipsum'),
(22, 4, 3, 20, '2022-05-09 22:02:02', 'Ekskursija traukiniu Varšuvoje lorem ipsum'),
(23, 4, 4, 30, '2022-05-09 22:02:02', 'Ekskursija tramvajumi Rygoje lorem ipsum'),
(24, 6, 2, 30, '2022-05-09 22:02:02', 'Pasiplaukiojimas Vilniuje  lorem ipsum'),
(25, 7, 7, 55, '2022-05-13 10:00:00', 'Kelione i Estija'),
(26, 7, 11, 230, '2022-05-16 16:30:00', 'Kelione I Prancuzija ir apsilankymas eifelio bokste'),
(27, 8, 12, 500, '2022-05-20 23:00:00', 'Kelione pas Roma I buta alaus'),
(28, 17, 12, 15, '2022-05-20 01:36:10', ':-)');

-- --------------------------------------------------------

--
-- Table structure for table `ekskursijos_klientai`
--

CREATE TABLE `ekskursijos_klientai` (
  `ID` int(11) NOT NULL,
  `Ekskursija_ID` int(11) NOT NULL,
  `Klientas_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ekskursijos_klientai`
--

INSERT INTO `ekskursijos_klientai` (`ID`, `Ekskursija_ID`, `Klientas_ID`) VALUES
(1, 21, 3),
(2, 21, 3);

-- --------------------------------------------------------

--
-- Table structure for table `ekskursijos_paslaugos`
--

CREATE TABLE `ekskursijos_paslaugos` (
  `ID` int(11) NOT NULL,
  `Ekskursijos_ID` int(11) NOT NULL,
  `Paslaugos_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ekskursijos_paslaugos`
--

INSERT INTO `ekskursijos_paslaugos` (`ID`, `Ekskursijos_ID`, `Paslaugos_ID`) VALUES
(6, 24, 7),
(7, 24, 8),
(8, 21, 8),
(9, 21, 8),
(10, 21, 11),
(11, 22, 10),
(12, 22, 6),
(13, 22, 12),
(14, 25, 11),
(15, 25, 7),
(16, 25, 8),
(17, 26, 10),
(18, 26, 12),
(19, 26, 13),
(20, 26, 6),
(21, 26, 7),
(22, 26, 8),
(23, 27, 6),
(24, 27, 7),
(25, 28, 14);

-- --------------------------------------------------------

--
-- Table structure for table `ekskursijos_transportas`
--

CREATE TABLE `ekskursijos_transportas` (
  `ID` int(10) NOT NULL,
  `Ekskursija_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ekskursijos_transportas`
--

INSERT INTO `ekskursijos_transportas` (`ID`, `Ekskursija_ID`) VALUES
(3, 21),
(2, 22),
(1, 23),
(4, 25),
(5, 26),
(6, 26);

-- --------------------------------------------------------

--
-- Table structure for table `gidas`
--

CREATE TABLE `gidas` (
  `ID` int(10) NOT NULL,
  `Vardas` varchar(20) NOT NULL,
  `Pavarde` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gidas`
--

INSERT INTO `gidas` (`ID`, `Vardas`, `Pavarde`) VALUES
(4, 'Martynas', 'Gusas'),
(6, 'Lukas', 'Valukonis'),
(7, 'Tomas', 'Kazlauskas'),
(8, 'Rokas', 'Minskas'),
(9, 'Raima', 'Lenkas'),
(10, 'Juozas', 'Piktas'),
(11, 'Kamile', 'Vems'),
(14, 'Modestas', 'Pavarges'),
(15, 'Karolis', 'Bukas'),
(16, 'Sernas', 'Liorka'),
(17, 'Migles', 'Gimse');

-- --------------------------------------------------------

--
-- Table structure for table `gidu_kalbos`
--

CREATE TABLE `gidu_kalbos` (
  `ID` int(10) NOT NULL,
  `Gido_ID` int(10) NOT NULL,
  `Kalbos_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gidu_kalbos`
--

INSERT INTO `gidu_kalbos` (`ID`, `Gido_ID`, `Kalbos_ID`) VALUES
(8, 4, 5),
(9, 4, 6),
(11, 6, 6),
(14, 15, 8),
(15, 16, 8),
(16, 4, 8),
(17, 4, 9),
(18, 14, 13),
(19, 16, 7),
(20, 9, 13),
(21, 7, 13);

-- --------------------------------------------------------

--
-- Table structure for table `kalbos`
--

CREATE TABLE `kalbos` (
  `ID` int(10) NOT NULL,
  `Kalba` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kalbos`
--

INSERT INTO `kalbos` (`ID`, `Kalba`) VALUES
(5, 'LT'),
(6, 'EN'),
(7, 'RU'),
(8, 'PL'),
(9, 'NO'),
(10, 'EST'),
(11, 'CZ'),
(12, 'SWE'),
(13, 'FR'),
(14, 'BR');

-- --------------------------------------------------------

--
-- Table structure for table `klientas`
--

CREATE TABLE `klientas` (
  `ID` int(11) NOT NULL,
  `Vardas` varchar(22) NOT NULL,
  `Pavarde` varchar(22) NOT NULL,
  `Adresas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `klientas`
--

INSERT INTO `klientas` (`ID`, `Vardas`, `Pavarde`, `Adresas`) VALUES
(3, 'Rokas', 'Valatka', 'S'),
(4, 'Armandas', 'Kimbirauskas', 'P');

-- --------------------------------------------------------

--
-- Table structure for table `marsrutas`
--

CREATE TABLE `marsrutas` (
  `ID` int(10) NOT NULL,
  `Pavadinimas` varchar(20) NOT NULL,
  `Tipas` varchar(20) NOT NULL,
  `Zemelapio_nuoroda` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `marsrutas`
--

INSERT INTO `marsrutas` (`ID`, `Pavadinimas`, `Tipas`, `Zemelapio_nuoroda`) VALUES
(1, 'Vargas', 'Misrus', 'www.google.maps/22'),
(2, 'Labai vargas', 'Misrus', 'www.google.maps/52'),
(3, 'Misko kelias', 'Misrus', 'www.google.maps/51'),
(4, 'Takelis', 'Uzdaras', 'www.google.maps/45'),
(5, 'Kalno takas', 'Atviras', 'www.google.maps/420');

-- --------------------------------------------------------

--
-- Table structure for table `miestas`
--

CREATE TABLE `miestas` (
  `ID` int(10) NOT NULL,
  `Salis_ID` int(10) NOT NULL,
  `Pavadinimas` varchar(20) NOT NULL,
  `Geo_padetis` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `miestas`
--

INSERT INTO `miestas` (`ID`, `Salis_ID`, `Pavadinimas`, `Geo_padetis`) VALUES
(2, 1, 'Vilnius', 'Europa'),
(3, 3, 'Varšuva', 'Europa'),
(4, 4, 'Ryga', 'Europa'),
(5, 1, 'Prienai', 'Europa'),
(6, 1, 'Kaunas', 'Europa'),
(7, 5, 'Talinas', 'Europa'),
(8, 6, 'Praha', 'Europa'),
(9, 7, 'Bratslava', 'Europa'),
(10, 8, 'Stokholmas', 'Europa'),
(11, 9, 'Paryzius', 'Europa'),
(12, 10, 'Roma', 'Europa');

-- --------------------------------------------------------

--
-- Table structure for table `parkavimas`
--

CREATE TABLE `parkavimas` (
  `ID` int(10) NOT NULL,
  `Takas_ID` int(10) DEFAULT NULL,
  `Bokstas_ID` int(10) DEFAULT NULL,
  `Pavadinimas` varchar(20) NOT NULL,
  `Vietu_skaicius` int(10) NOT NULL,
  `Kaina` float NOT NULL,
  `Lokacija` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `parkavimas`
--

INSERT INTO `parkavimas` (`ID`, `Takas_ID`, `Bokstas_ID`, `Pavadinimas`, `Vietu_skaicius`, `Kaina`, `Lokacija`) VALUES
(1, 1, 1, 'Vilniaus parking', 23, 5, 'Vilnius'),
(2, 2, 1, 'Kauno parking', 144, 2, 'Kaunas'),
(7, 3, NULL, 'Parkavimas mieste', 20, 0.6, 'Varsuva'),
(8, NULL, 5, 'Stovejimo aikstele', 20, 5, 'Paryzius'),
(9, 4, 9, 'Tako aikstele', 40, 1, 'Ryga'),
(10, 5, 6, 'Tatro takas', 20, 2, 'Talinas');

-- --------------------------------------------------------

--
-- Table structure for table `paslauga`
--

CREATE TABLE `paslauga` (
  `ID` int(10) NOT NULL,
  `Pavadinimas` varchar(50) NOT NULL,
  `Kaina` float NOT NULL,
  `Kiekis` int(100) NOT NULL,
  `Trukme` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `paslauga`
--

INSERT INTO `paslauga` (`ID`, `Pavadinimas`, `Kaina`, `Kiekis`, `Trukme`) VALUES
(6, 'Pusryciai', 20, 10, 1),
(7, 'Vakariene', 15, 20, 1),
(8, 'Pietus', 10, 40, 1),
(9, 'Ausines', 4, 25, 100),
(10, 'Nakvyne', 45, 20, 1),
(11, 'Palapines nuoma', 15, 10, 12),
(12, 'Tuoletas', 0.5, 2, 1),
(13, 'Wi-Fi', 5, 1, 24),
(14, 'sakes keitimas', 10, 1, 5);

-- --------------------------------------------------------

--
-- Table structure for table `pazintinio_tako_marsrutas`
--

CREATE TABLE `pazintinio_tako_marsrutas` (
  `ID` int(10) NOT NULL,
  `Takas_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pazintinio_tako_marsrutas`
--

INSERT INTO `pazintinio_tako_marsrutas` (`ID`, `Takas_ID`) VALUES
(2, 1),
(1, 2),
(3, 4),
(4, 5),
(5, 7);

-- --------------------------------------------------------

--
-- Table structure for table `pazintinis_takas`
--

CREATE TABLE `pazintinis_takas` (
  `ID` int(10) NOT NULL,
  `Ekskursija_ID` int(10) NOT NULL,
  `Pavadinimas` varchar(20) NOT NULL,
  `Ilgis` float NOT NULL,
  `Kaina` float NOT NULL,
  `Trukme` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pazintinis_takas`
--

INSERT INTO `pazintinis_takas` (`ID`, `Ekskursija_ID`, `Pavadinimas`, `Ilgis`, `Kaina`, `Trukme`) VALUES
(1, 21, 'Aplink Vilniu', 53, 20, 4),
(2, 24, 'Aplink Kauna', 40, 54, 3),
(3, 22, 'Miesto takas', 12, 0, 2),
(4, 23, 'Misko takas', 3, 0, 1),
(5, 25, 'Tatro takas', 22, 5, 5),
(6, 26, 'Miesto parkas', 15, 5, 2),
(7, 23, 'Kalno takas', 8, 10, 2);

-- --------------------------------------------------------

--
-- Table structure for table `salis`
--

CREATE TABLE `salis` (
  `ID` int(10) NOT NULL,
  `Pavadinimas` varchar(20) NOT NULL,
  `Geo_padetis` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salis`
--

INSERT INTO `salis` (`ID`, `Pavadinimas`, `Geo_padetis`) VALUES
(1, 'Lietuva', 'Europa'),
(3, 'Lenkija', 'Europa'),
(4, 'Latvija', 'Europa'),
(5, 'Estija', 'Europa'),
(6, 'Cekija', 'Europa'),
(7, 'Slovakia', 'Europa'),
(8, 'Svedija', 'Europa'),
(9, 'Prancuzija', 'Europa'),
(10, 'Italija', 'Europa');

-- --------------------------------------------------------

--
-- Table structure for table `tako_dangos`
--

CREATE TABLE `tako_dangos` (
  `ID` int(10) NOT NULL,
  `Takas_ID` int(10) NOT NULL,
  `DangosTipas_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tako_dangos`
--

INSERT INTO `tako_dangos` (`ID`, `Takas_ID`, `DangosTipas_ID`) VALUES
(1, 2, 3),
(2, 1, 3),
(3, 3, 4),
(4, 4, 7),
(5, 5, 9),
(6, 6, 4),
(7, 7, 8);

-- --------------------------------------------------------

--
-- Table structure for table `transportas`
--

CREATE TABLE `transportas` (
  `ID` int(10) NOT NULL,
  `Transporto_tipas` varchar(20) NOT NULL,
  `Vietu_skaicius` int(10) NOT NULL,
  `Kaina` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transportas`
--

INSERT INTO `transportas` (`ID`, `Transporto_tipas`, `Vietu_skaicius`, `Kaina`) VALUES
(1, 'Minivenas', 6, 40),
(2, 'Autobusas', 15, 100),
(3, 'Traukinys', 50, 2.5),
(4, 'Laivas', 45, 50),
(5, 'Lektuvas', 20, 460),
(6, 'Maxi_bus', 50, 120),
(7, 'Armando_mersas', 5, 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `architektas`
--
ALTER TABLE `architektas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bokstas`
--
ALTER TABLE `bokstas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Ekskursija_ID` (`Ekskursija_ID`);

--
-- Indexes for table `boksto_architektai`
--
ALTER TABLE `boksto_architektai`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Bokstas_ID` (`Bokstas_ID`);

--
-- Indexes for table `dangos_tipas`
--
ALTER TABLE `dangos_tipas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `ekskursijos`
--
ALTER TABLE `ekskursijos`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Gidas_ID` (`Gidas_ID`),
  ADD KEY `Miestas_ID` (`Miestas_ID`);

--
-- Indexes for table `ekskursijos_klientai`
--
ALTER TABLE `ekskursijos_klientai`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Ekskursija_ID` (`Ekskursija_ID`),
  ADD KEY `Klientas_ID` (`Klientas_ID`);

--
-- Indexes for table `ekskursijos_paslaugos`
--
ALTER TABLE `ekskursijos_paslaugos`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Ekskursijos_ID` (`Ekskursijos_ID`),
  ADD KEY `Paslaugos_ID` (`Paslaugos_ID`),
  ADD KEY `Ekskursijos_ID_2` (`Ekskursijos_ID`),
  ADD KEY `Paslaugos_ID_2` (`Paslaugos_ID`);

--
-- Indexes for table `ekskursijos_transportas`
--
ALTER TABLE `ekskursijos_transportas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Ekskursija_ID` (`Ekskursija_ID`);

--
-- Indexes for table `gidas`
--
ALTER TABLE `gidas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `gidu_kalbos`
--
ALTER TABLE `gidu_kalbos`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Kalbos_ID` (`Kalbos_ID`),
  ADD KEY `Gido_ID` (`Gido_ID`);

--
-- Indexes for table `kalbos`
--
ALTER TABLE `kalbos`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `klientas`
--
ALTER TABLE `klientas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `marsrutas`
--
ALTER TABLE `marsrutas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `miestas`
--
ALTER TABLE `miestas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Salis_ID` (`Salis_ID`);

--
-- Indexes for table `parkavimas`
--
ALTER TABLE `parkavimas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Takas_ID` (`Takas_ID`),
  ADD KEY `Bokstas_ID` (`Bokstas_ID`);

--
-- Indexes for table `paslauga`
--
ALTER TABLE `paslauga`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pazintinio_tako_marsrutas`
--
ALTER TABLE `pazintinio_tako_marsrutas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Takas_ID` (`Takas_ID`);

--
-- Indexes for table `pazintinis_takas`
--
ALTER TABLE `pazintinis_takas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Ekskursija_ID` (`Ekskursija_ID`);

--
-- Indexes for table `salis`
--
ALTER TABLE `salis`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tako_dangos`
--
ALTER TABLE `tako_dangos`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Takas_ID` (`Takas_ID`),
  ADD KEY `DangosTipas_ID` (`DangosTipas_ID`);

--
-- Indexes for table `transportas`
--
ALTER TABLE `transportas`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `architektas`
--
ALTER TABLE `architektas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `bokstas`
--
ALTER TABLE `bokstas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `dangos_tipas`
--
ALTER TABLE `dangos_tipas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `ekskursijos`
--
ALTER TABLE `ekskursijos`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
--
-- AUTO_INCREMENT for table `ekskursijos_klientai`
--
ALTER TABLE `ekskursijos_klientai`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `ekskursijos_paslaugos`
--
ALTER TABLE `ekskursijos_paslaugos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `gidas`
--
ALTER TABLE `gidas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `gidu_kalbos`
--
ALTER TABLE `gidu_kalbos`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `kalbos`
--
ALTER TABLE `kalbos`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `klientas`
--
ALTER TABLE `klientas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `marsrutas`
--
ALTER TABLE `marsrutas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `miestas`
--
ALTER TABLE `miestas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `parkavimas`
--
ALTER TABLE `parkavimas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `paslauga`
--
ALTER TABLE `paslauga`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `pazintinis_takas`
--
ALTER TABLE `pazintinis_takas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `salis`
--
ALTER TABLE `salis`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `tako_dangos`
--
ALTER TABLE `tako_dangos`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `transportas`
--
ALTER TABLE `transportas`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `bokstas`
--
ALTER TABLE `bokstas`
  ADD CONSTRAINT `bokstas_ibfk_1` FOREIGN KEY (`Ekskursija_ID`) REFERENCES `ekskursijos` (`ID`);

--
-- Constraints for table `boksto_architektai`
--
ALTER TABLE `boksto_architektai`
  ADD CONSTRAINT `boksto_architektai_ibfk_1` FOREIGN KEY (`Bokstas_ID`) REFERENCES `bokstas` (`ID`),
  ADD CONSTRAINT `boksto_architektai_ibfk_2` FOREIGN KEY (`ID`) REFERENCES `architektas` (`ID`);

--
-- Constraints for table `ekskursijos`
--
ALTER TABLE `ekskursijos`
  ADD CONSTRAINT `ekskursijos_ibfk_1` FOREIGN KEY (`Miestas_ID`) REFERENCES `miestas` (`ID`),
  ADD CONSTRAINT `ekskursijos_ibfk_2` FOREIGN KEY (`Gidas_ID`) REFERENCES `gidas` (`ID`);

--
-- Constraints for table `ekskursijos_klientai`
--
ALTER TABLE `ekskursijos_klientai`
  ADD CONSTRAINT `ekskursijos_klientai_ibfk_1` FOREIGN KEY (`Klientas_ID`) REFERENCES `klientas` (`ID`),
  ADD CONSTRAINT `ekskursijos_klientai_ibfk_2` FOREIGN KEY (`Ekskursija_ID`) REFERENCES `ekskursijos` (`ID`);

--
-- Constraints for table `ekskursijos_paslaugos`
--
ALTER TABLE `ekskursijos_paslaugos`
  ADD CONSTRAINT `ekskursijos_paslaugos_ibfk_1` FOREIGN KEY (`Paslaugos_ID`) REFERENCES `paslauga` (`ID`),
  ADD CONSTRAINT `ekskursijos_paslaugos_ibfk_2` FOREIGN KEY (`Ekskursijos_ID`) REFERENCES `ekskursijos` (`ID`);

--
-- Constraints for table `ekskursijos_transportas`
--
ALTER TABLE `ekskursijos_transportas`
  ADD CONSTRAINT `ekskursijos_transportas_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `transportas` (`ID`),
  ADD CONSTRAINT `ekskursijos_transportas_ibfk_2` FOREIGN KEY (`Ekskursija_ID`) REFERENCES `ekskursijos` (`ID`);

--
-- Constraints for table `gidu_kalbos`
--
ALTER TABLE `gidu_kalbos`
  ADD CONSTRAINT `gidu_kalbos_ibfk_1` FOREIGN KEY (`Kalbos_ID`) REFERENCES `kalbos` (`ID`),
  ADD CONSTRAINT `gidu_kalbos_ibfk_2` FOREIGN KEY (`Gido_ID`) REFERENCES `gidas` (`ID`);

--
-- Constraints for table `miestas`
--
ALTER TABLE `miestas`
  ADD CONSTRAINT `miestas_ibfk_1` FOREIGN KEY (`Salis_ID`) REFERENCES `salis` (`ID`);

--
-- Constraints for table `parkavimas`
--
ALTER TABLE `parkavimas`
  ADD CONSTRAINT `parkavimas_ibfk_1` FOREIGN KEY (`Takas_ID`) REFERENCES `pazintinis_takas` (`ID`),
  ADD CONSTRAINT `parkavimas_ibfk_2` FOREIGN KEY (`Bokstas_ID`) REFERENCES `bokstas` (`ID`);

--
-- Constraints for table `pazintinio_tako_marsrutas`
--
ALTER TABLE `pazintinio_tako_marsrutas`
  ADD CONSTRAINT `pazintinio_tako_marsrutas_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `marsrutas` (`ID`),
  ADD CONSTRAINT `pazintinio_tako_marsrutas_ibfk_2` FOREIGN KEY (`Takas_ID`) REFERENCES `pazintinis_takas` (`ID`);

--
-- Constraints for table `pazintinis_takas`
--
ALTER TABLE `pazintinis_takas`
  ADD CONSTRAINT `pazintinis_takas_ibfk_1` FOREIGN KEY (`Ekskursija_ID`) REFERENCES `ekskursijos` (`ID`);

--
-- Constraints for table `tako_dangos`
--
ALTER TABLE `tako_dangos`
  ADD CONSTRAINT `tako_dangos_ibfk_1` FOREIGN KEY (`Takas_ID`) REFERENCES `pazintinis_takas` (`ID`),
  ADD CONSTRAINT `tako_dangos_ibfk_2` FOREIGN KEY (`DangosTipas_ID`) REFERENCES `dangos_tipas` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
