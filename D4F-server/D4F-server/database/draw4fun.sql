-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: Ne 22.Máj 2016, 22:40
-- Verzia serveru: 5.6.17
-- Verzia PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databáza: `draw4fun`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `drawings`
--

CREATE TABLE IF NOT EXISTS `drawings` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `wordid` int(10) unsigned NOT NULL,
  `painter` int(10) unsigned NOT NULL,
  `reciever` int(10) unsigned NOT NULL,
  `combo` int(10) unsigned NOT NULL,
  `state` int(10) unsigned NOT NULL COMMENT '0 - PENDING, 1 - UNSUCCESSFUL GUESS, 2 - SUCCESSFUL GUESS',
  `datepainted` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016' AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `friendships`
--

CREATE TABLE IF NOT EXISTS `friendships` (
  `user1` int(10) unsigned NOT NULL,
  `user2` int(10) unsigned NOT NULL,
  PRIMARY KEY (`user1`,`user2`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

--
-- Sťahujem dáta pre tabuľku `friendships`
--

INSERT INTO `friendships` (`user1`, `user2`) VALUES
(1, 2),
(1, 3),
(1, 4),
(2, 3),
(2, 4),
(3, 4);

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `streams`
--

CREATE TABLE IF NOT EXISTS `streams` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `streambinary` longblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016' AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nickname` varchar(15) COLLATE utf8_bin NOT NULL,
  `password` varchar(15) COLLATE utf8_bin NOT NULL,
  `dateregistered` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nickname` (`nickname`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016' AUTO_INCREMENT=5 ;

--
-- Sťahujem dáta pre tabuľku `users`
--

INSERT INTO `users` (`id`, `nickname`, `password`, `dateregistered`) VALUES
(1, 'superjozko98', 'mamradvlaky', '2016-04-05'),
(2, 'ferobatman', 'pizzapizza', '2016-04-04'),
(3, 'tyranosaurus27', 'mrkvajefajn11', '2016-04-05'),
(4, 'd0naldtrumpz', 'alabama123', '2016-04-05');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `wordcategories`
--

CREATE TABLE IF NOT EXISTS `wordcategories` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(15) COLLATE utf8_bin NOT NULL,
  `points` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016' AUTO_INCREMENT=6 ;

--
-- Sťahujem dáta pre tabuľku `wordcategories`
--

INSERT INTO `wordcategories` (`id`, `name`, `points`) VALUES
(1, 'easy', 50),
(2, 'medium', 75),
(3, 'hard', 100),
(4, 'extreme', 150),
(5, 'wizard', 250);

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `words`
--

CREATE TABLE IF NOT EXISTS `words` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `word` varchar(15) COLLATE utf8_bin NOT NULL,
  `category` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `word` (`word`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016' AUTO_INCREMENT=17 ;

--
-- Sťahujem dáta pre tabuľku `words`
--

INSERT INTO `words` (`id`, `word`, `category`) VALUES
(1, 'apple', 1),
(2, 'banana', 1),
(3, 'horse', 1),
(4, 'pizza', 1),
(5, 'taco', 1),
(6, 'murderer', 2),
(7, 'policeman', 2),
(8, 'hippie', 2),
(9, 'happiness', 2),
(10, 'mexico', 2),
(11, 'prophet', 3),
(12, 'bankrupcy', 3),
(13, 'insanity', 4),
(14, 'propaganda', 4),
(15, 'nonsense', 5),
(16, 'anxiety', 5);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
