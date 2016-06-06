-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: Po 06.Jún 2016, 10:41
-- Verzia serveru: 5.7.11
-- Verzia PHP: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `draw4fun`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `drawings`
--

CREATE TABLE `drawings` (
  `id` int(10) UNSIGNED NOT NULL,
  `wordid` int(10) UNSIGNED NOT NULL,
  `painter` int(10) UNSIGNED NOT NULL,
  `reciever` int(10) UNSIGNED NOT NULL,
  `combo` int(10) UNSIGNED NOT NULL,
  `state` int(10) UNSIGNED NOT NULL COMMENT '0 - PENDING, 1 - UNSUCCESSFUL GUESS, 2 - SUCCESSFUL GUESS',
  `datepainted` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

--
-- Sťahujem dáta pre tabuľku `drawings`
--

INSERT INTO `drawings` (`id`, `wordid`, `painter`, `reciever`, `combo`, `state`, `datepainted`) VALUES
(1, 1, 10, 11, 1, 2, '2016-06-06 08:54:39'),
(2, 2, 12, 13, 1, 2, '2016-06-06 08:54:39'),
(3, 3, 14, 15, 1, 2, '2016-06-06 08:59:06'),
(4, 4, 16, 17, 1, 2, '2016-06-06 08:59:06'),
(5, 5, 18, 19, 1, 2, '2016-06-06 08:59:06'),
(6, 6, 20, 21, 1, 2, '2016-06-06 08:59:06'),
(7, 7, 22, 23, 1, 2, '2016-06-06 08:59:06'),
(8, 8, 24, 25, 1, 2, '2016-06-06 09:01:46'),
(9, 9, 5, 6, 1, 2, '2016-06-06 09:01:46'),
(10, 10, 10, 12, 1, 2, '2016-06-06 09:01:46'),
(11, 11, 14, 20, 1, 1, '2016-06-06 09:01:46'),
(12, 12, 18, 21, 1, 1, '2016-06-06 09:01:46'),
(13, 13, 24, 25, 2, 2, '2016-06-06 09:05:55'),
(14, 14, 23, 25, 1, 2, '2016-06-06 09:05:55'),
(15, 15, 8, 10, 1, 2, '2016-06-06 09:05:55'),
(16, 16, 8, 12, 1, 1, '2016-06-06 09:05:55'),
(17, 1, 13, 20, 1, 2, '2016-06-06 09:05:55'),
(18, 2, 14, 15, 2, 2, '2016-06-06 09:10:37'),
(19, 7, 8, 25, 1, 2, '2016-06-06 09:10:37'),
(20, 9, 16, 17, 2, 2, '2016-06-06 09:10:37'),
(21, 12, 12, 10, 2, 1, '2016-06-06 09:10:37'),
(22, 15, 17, 21, 1, 2, '2016-06-06 09:10:37'),
(23, 3, 13, 16, 1, 2, '2016-06-06 09:14:53'),
(24, 4, 13, 17, 1, 2, '2016-06-06 09:14:53'),
(25, 14, 11, 17, 1, 1, '2016-06-06 09:14:53');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `friendships`
--

CREATE TABLE `friendships` (
  `user1` int(10) UNSIGNED NOT NULL,
  `user2` int(10) UNSIGNED NOT NULL
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

CREATE TABLE `streams` (
  `id` int(10) UNSIGNED NOT NULL,
  `streambinary` longtext COLLATE utf8_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `users`
--

CREATE TABLE `users` (
  `id` int(10) UNSIGNED NOT NULL,
  `nickname` varchar(15) COLLATE utf8_bin NOT NULL,
  `password` varchar(50) COLLATE utf8_bin NOT NULL,
  `dateregistered` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

--
-- Sťahujem dáta pre tabuľku `users`
--

INSERT INTO `users` (`id`, `nickname`, `password`, `dateregistered`) VALUES
(5, 'MarekJeDrzy', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(6, 'Pomaranc', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(7, 'marekSibal', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(8, 'karol', 'Qo94v0JpPaL59LS6U3xfEB4nVgc=', NULL),
(10, 'pato', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(11, 'brano', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(12, 'michal', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(13, 'matus', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(14, 'slovensko', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(15, 'bandaska', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(16, 'itguy', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(17, 'daniel', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(18, 'faker', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(19, 'wildturtle', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(20, 'bjergsen', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(21, 'doublelift', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(22, 'fnatic', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(23, 'tempostorm', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(24, 'reynad', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(25, 'forsen', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL);

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `wordcategories`
--

CREATE TABLE `wordcategories` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(15) COLLATE utf8_bin NOT NULL,
  `points` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

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

CREATE TABLE `words` (
  `id` int(10) UNSIGNED NOT NULL,
  `word` varchar(15) COLLATE utf8_bin NOT NULL,
  `category` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

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
(16, 'anxiety', 5),
(17, 'car', 1),
(18, 'train', 1),
(19, 'computer', 1),
(20, 'keyboard', 1),
(21, 'television', 1),
(22, 'firefighter', 2),
(23, 'table', 2),
(24, 'knife', 2),
(25, 'dentist', 2),
(26, 'toaster', 2),
(27, 'fridge', 2),
(28, 'battleship', 3),
(29, 'website', 3),
(30, 'facebook', 3),
(31, 'tank', 3),
(32, 'soccer ball', 3),
(33, 'sea', 3),
(34, 'salt', 3),
(35, 'insects', 3),
(36, 'war', 4),
(37, 'space', 4),
(38, 'depression', 4),
(39, 'number', 4),
(40, 'iron', 4),
(41, 'internet', 4),
(42, 'twitter', 4),
(43, 'proton', 5),
(44, 'electricity', 5),
(45, 'rage', 5),
(46, 'illness', 5),
(47, 'drugs', 5),
(48, 'social media', 5),
(49, 'math', 5);

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `drawings`
--
ALTER TABLE `drawings`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexy pre tabuľku `friendships`
--
ALTER TABLE `friendships`
  ADD PRIMARY KEY (`user1`,`user2`);

--
-- Indexy pre tabuľku `streams`
--
ALTER TABLE `streams`
  ADD PRIMARY KEY (`id`);

--
-- Indexy pre tabuľku `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nickname` (`nickname`);

--
-- Indexy pre tabuľku `wordcategories`
--
ALTER TABLE `wordcategories`
  ADD PRIMARY KEY (`id`);

--
-- Indexy pre tabuľku `words`
--
ALTER TABLE `words`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `word` (`word`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `drawings`
--
ALTER TABLE `drawings`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT pre tabuľku `streams`
--
ALTER TABLE `streams`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pre tabuľku `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT pre tabuľku `wordcategories`
--
ALTER TABLE `wordcategories`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT pre tabuľku `words`
--
ALTER TABLE `words`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
