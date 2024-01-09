-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2023 at 05:24 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aquadrops`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblconfirmtotal`
--

CREATE TABLE `tblconfirmtotal` (
  `ID` int(11) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Jar_Type` varchar(100) NOT NULL,
  `Price` float NOT NULL,
  `Total_Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblconfirmtotal`
--

INSERT INTO `tblconfirmtotal` (`ID`, `QTY`, `Jar_Type`, `Price`, `Total_Amount`) VALUES
(1, 3, '20 LITER \"GALLON CONTAINER \"', 40, 120),
(2, 5, '5 LITER \"GALLON CONTAINER \"', 20, 100),
(3, 10, '10 LITER \"GALLON CONTAINER \"', 30, 300),
(4, 5, '1.5 LITER CONTAINER', 10, 50),
(5, 20, '1 LITER CONTAINER', 7, 140),
(6, 3, '1/2 LITER WATER CONTAINER', 5, 15),
(7, 80, '20 LITER \"GALLON CONTAINER \"', 40, 3200),
(8, 10, '10 LITER \"GALLON CONTAINER \"', 30, 300),
(9, 4, '1 LITER CONTAINER', 7, 28),
(10, 4, '5 LITER \"GALLON CONTAINER \"', 20, 80);

-- --------------------------------------------------------

--
-- Table structure for table `tbljartype`
--

CREATE TABLE `tbljartype` (
  `ID` int(11) NOT NULL,
  `DATECREATED` date NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(100) NOT NULL,
  `PRICE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbljartype`
--

INSERT INTO `tbljartype` (`ID`, `DATECREATED`, `NAME`, `DESCRIPTION`, `PRICE`) VALUES
(1, '2023-11-01', '20 LITER \"GALLON CONTAINER \"', 'A REFILL OF 20 LITER WATERCONTAINER', 40),
(2, '2023-11-07', '10 LITER \"GALLON CONTAINER \"', 'A REFILL OF 10 LITER WATER CONTAINER', 30),
(3, '2023-11-09', '5 LITER \"GALLON CONTAINER \"', 'A REFILL OF A 5 LITER WATER CONTAINER', 20),
(4, '2023-11-10', '1.5 LITER CONTAINER', 'A REFILL OF A 1.5 WATER CONTAINER', 10),
(5, '2023-11-13', '1 LITER CONTAINER', 'REFILL OF ONE LITER WATER CONTAINER', 7),
(6, '2023-11-15', '1/2 LITER WATER CONTAINER', 'A REFILL OF ANY 1/2 LITER WATER CONTAINER', 5),
(7, '2023-11-19', 'A GLASS OF WATER', 'REFILL OF ANY GLASS OF WATER', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tblsale`
--

CREATE TABLE `tblsale` (
  `ID` int(11) NOT NULL,
  `DATECREATED` date NOT NULL,
  `CUSTOMER_NAME` varchar(100) NOT NULL,
  `TYPE` varchar(100) NOT NULL,
  `STATUS` varchar(100) NOT NULL,
  `TOTAL_ITEM` varchar(100) NOT NULL,
  `AMOUNT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblsale`
--

INSERT INTO `tblsale` (`ID`, `DATECREATED`, `CUSTOMER_NAME`, `TYPE`, `STATUS`, `TOTAL_ITEM`, `AMOUNT`) VALUES
(1, '2023-11-01', 'CYDHEN AVENA', 'FOR DELIVERY', 'PAID', '3', 120),
(2, '2023-11-03', 'MARK SORIANO', 'WALK-IN', 'PAID', '5', 100),
(3, '2023-11-06', 'RAFAELA ADVINCULA', 'FOR DELIVERY', 'UNPAID', '10', 300),
(4, '2023-11-07', 'RICA MATEO', 'WALK-IN', 'PAID', '5', 50),
(5, '2023-11-07', 'RONNIE TABIANO', 'FOR DELIVERY', 'UNPAID', '20', 140),
(6, '2023-11-09', 'ERNEST VALDERAMA', 'WALK-IN', 'PAID', '3', 15),
(7, '2023-11-13', 'ALDRIN ANDRADE', 'FOR DELIVERY', 'UNPAID', '80', 3200),
(8, '2023-11-16', 'BEN NUÑEZ', 'FOR DELIVERY', 'PAID', '10', 300),
(9, '2023-11-18', 'MARINELLE ANDO', 'WALK-IN', 'UNPAID', '4', 28),
(10, '2023-11-21', 'OSCAR WENDELL', 'FOR DELIVERY', 'PAID', '4', 80);

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `ID` int(11) NOT NULL,
  `FIRSTNAME` varchar(100) NOT NULL,
  `LASTNAME` varchar(100) NOT NULL,
  `USERNAME` varchar(100) NOT NULL,
  `PASSWORD` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`ID`, `FIRSTNAME`, `LASTNAME`, `USERNAME`, `PASSWORD`) VALUES
(1, 'Admin', 'admin123', 'admin', 'admin123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblconfirmtotal`
--
ALTER TABLE `tblconfirmtotal`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbljartype`
--
ALTER TABLE `tbljartype`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblsale`
--
ALTER TABLE `tblsale`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblconfirmtotal`
--
ALTER TABLE `tblconfirmtotal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbljartype`
--
ALTER TABLE `tbljartype`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblsale`
--
ALTER TABLE `tblsale`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
