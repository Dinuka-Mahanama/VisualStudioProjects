-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 15, 2019 at 03:20 PM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `student`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
CREATE TABLE IF NOT EXISTS `course` (
  `CurId` varchar(11) NOT NULL,
  `CurName` varchar(11) NOT NULL,
  `Fees` int(11) NOT NULL,
  `LecId` varchar(11) NOT NULL,
  `Descp` varchar(11) NOT NULL,
  PRIMARY KEY (`CurId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`CurId`, `CurName`, `Fees`, `LecId`, `Descp`) VALUES
('c001', 'Maths', 5125055, 'l001', 'sdvsdvsdc'),
('c002', 'English', 25145652, 'l002', 'scsdsfse');

-- --------------------------------------------------------

--
-- Table structure for table `lecture`
--

DROP TABLE IF EXISTS `lecture`;
CREATE TABLE IF NOT EXISTS `lecture` (
  `LecId` varchar(255) NOT NULL,
  `LecName` varchar(255) NOT NULL,
  `LecTel` int(255) NOT NULL,
  `Qual` varchar(255) NOT NULL,
  `Salary` int(255) NOT NULL,
  PRIMARY KEY (`LecId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lecture`
--

INSERT INTO `lecture` (`LecId`, `LecName`, `LecTel`, `Qual`, `Salary`) VALUES
('l001', 'abcd', 1451515, 'bsc in something', 25000),
('l002', 'efgh', 62526151, 'bsc in something', 50000);

-- --------------------------------------------------------

--
-- Table structure for table `studetmain`
--

DROP TABLE IF EXISTS `studetmain`;
CREATE TABLE IF NOT EXISTS `studetmain` (
  `StuId` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `MarkAs` int(255) NOT NULL,
  `MarkEx` int(255) NOT NULL,
  `StuTel` int(225) NOT NULL,
  `CorId` varchar(255) NOT NULL,
  PRIMARY KEY (`StuId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studetmain`
--

INSERT INTO `studetmain` (`StuId`, `Name`, `MarkAs`, `MarkEx`, `StuTel`, `CorId`) VALUES
('s0001', 'abcd', 85, 1000, 262552, 'c001'),
('s0002', 'efgh', 96, 63, 11478332, 'c002'),
('s0003', 'test', 25, 25, 534242, 'c002');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
