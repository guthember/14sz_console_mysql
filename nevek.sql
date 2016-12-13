-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2016. Dec 13. 14:26
-- Kiszolgáló verziója: 10.1.19-MariaDB
-- PHP verzió: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `proba`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `nevek`
--

DROP TABLE IF EXISTS `nevek`;
CREATE TABLE `nevek` (
  `nevid` int(11) NOT NULL,
  `nev` varchar(20) DEFAULT NULL,
  `cim` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `nevek`
--

INSERT INTO `nevek` (`nevid`, `nev`, `cim`) VALUES
(1, 'Nagy Janos', '2649 Orhalom, Kossuth ut 1.'),
(2, 'Kiss Laszlo', '2660 Balassagyarmat, Rakoczi 2.'),
(3, 'Peter Pal', '1100 Budapest, Diofa ut 23.'),
(4, 'Kovi Laszlo', '2310 Miskolc, Ujfa 11/B.');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `nevek`
--
ALTER TABLE `nevek`
  ADD PRIMARY KEY (`nevid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `nevek`
--
ALTER TABLE `nevek`
  MODIFY `nevid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
