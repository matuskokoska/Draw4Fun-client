
--
-- Databáza: `draw4fun`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `drawings`
--

DROP TABLE IF EXISTS `drawings`;
CREATE TABLE IF NOT EXISTS `drawings` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `wordid` int(10) UNSIGNED NOT NULL,
  `painter` int(10) UNSIGNED NOT NULL,
  `reciever` int(10) UNSIGNED NOT NULL,
  `combo` int(10) UNSIGNED NOT NULL,
  `state` int(10) UNSIGNED NOT NULL COMMENT '0 - PENDING, 1 - UNSUCCESSFUL GUESS, 2 - SUCCESSFUL GUESS',
  `datepainted` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `friendships`
--

DROP TABLE IF EXISTS `friendships`;
CREATE TABLE IF NOT EXISTS `friendships` (
  `user1` int(10) UNSIGNED NOT NULL,
  `user2` int(10) UNSIGNED NOT NULL,
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

DROP TABLE IF EXISTS `streams`;
CREATE TABLE IF NOT EXISTS `streams` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `streambinary` longtext,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nickname` varchar(15) COLLATE utf8_bin NOT NULL,
  `password` varchar(50) COLLATE utf8_bin NOT NULL,
  `dateregistered` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nickname` (`nickname`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

--
-- Sťahujem dáta pre tabuľku `users`
--

INSERT INTO `users` (`id`, `nickname`, `password`, `dateregistered`) VALUES
(5, 'MarekJeDrzy', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(6, 'Pomaranc', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL),
(7, 'marekSibal', 'Bh9+eoZOaRZgt0KyjA4HjkFysJo=', NULL);

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `wordcategories`
--

DROP TABLE IF EXISTS `wordcategories`;
CREATE TABLE IF NOT EXISTS `wordcategories` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(15) COLLATE utf8_bin NOT NULL,
  `points` int(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

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

DROP TABLE IF EXISTS `words`;
CREATE TABLE IF NOT EXISTS `words` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `word` varchar(15) COLLATE utf8_bin NOT NULL,
  `category` int(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `word` (`word`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Created by Matúš Kokoška - 05.04.2016';

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



