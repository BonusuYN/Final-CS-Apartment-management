-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 26, 2022 at 06:09 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `luckyplace`
--

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `id` int(11) NOT NULL,
  `room` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `feedback` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `info` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `how` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`id`, `room`, `feedback`, `info`, `status`, `how`, `time`) VALUES
(1, '1102', 'ห้องข้างๆเสียงดัง', 'ห้องข้างๆเสียงดังตอนตี1 ตี2', 'แจ้งเตือนเรียบร้อยแล้ว', '', '2022-06-22 17:54:57'),
(2, '1202', 'ห้องข้างๆเลี้ยงหมา', 'ห้องข้างๆเลี้ยงหมาเห่าเสียงดังมากตอนกลางคืน', 'แจ้งเตือนเรียบร้อยแล้ว', 'ขึ้นไปเพื่อเช็คเบื้องต้นว่าเลี้ยงจริงหรือไม่และตักเตือนเรียบร้อย', '2022-07-02 09:27:39'),
(3, '1201', 'รถโดนเฉี่ยว', 'รถโดนเฉี่ยวตอนหัวค่ำค่ะเป็นรอยเล็กน้อย ขอดูกล้องวงจรปิดได้ไหมคะ?', 'แจ้งเตือนเรียบร้อยแล้ว', '', '2022-06-22 17:57:16'),
(4, '1201', 'ห้องข้างๆเสียงดัง', 'ห้องข้างๆบ่นเสียงดังไม่ได้หลับไม่ได้นอนเลยครับ', 'แจ้งเตือนเรียบร้อยแล้ว', 'ทำการติดต่อเพื่อแจ้งเตือนเรียบร้อยแล้ว', '2022-07-02 09:25:47'),
(5, '1201', 'ห้อง1202เสียงดัง', 'ช่วงตี2ตี3ห้องข้างๆเสียงดังแบบเปิดเพลงเสียงดังตอนกลางดึกครับ', 'แจ้งเตือนเรียบร้อยแล้ว', 'โทรไปตักเตือนเรียบร้อย', '2022-08-25 16:23:38');

-- --------------------------------------------------------

--
-- Table structure for table `rentalfee`
--

CREATE TABLE `rentalfee` (
  `room` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `newelec` int(11) NOT NULL,
  `oldelec` int(11) NOT NULL,
  `useelec` int(11) NOT NULL,
  `summitelec` int(11) NOT NULL,
  `newwater` int(11) NOT NULL,
  `oldwater` int(11) NOT NULL,
  `usewater` int(11) NOT NULL,
  `summitwater` int(11) NOT NULL,
  `priceroom` int(11) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `rentalfee`
--

INSERT INTO `rentalfee` (`room`, `newelec`, `oldelec`, `useelec`, `summitelec`, `newwater`, `oldwater`, `usewater`, `summitwater`, `priceroom`, `total`) VALUES
('1101', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1102', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1103', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1104', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1105', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1201', 1600, 1550, 50, 300, 521, 520, 1, 25, 4000, 4325),
('1202', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1203', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1204', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000),
('1205', 0, 0, 0, 0, 0, 0, 0, 0, 4000, 4000);

-- --------------------------------------------------------

--
-- Table structure for table `residents_name`
--

CREATE TABLE `residents_name` (
  `room` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tel` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dob` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `faculty` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `year` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `parent_name` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `parent_tel` varchar(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `arrival_date` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `residents_name`
--

INSERT INTO `residents_name` (`room`, `name`, `tel`, `dob`, `faculty`, `year`, `address`, `parent_name`, `parent_tel`, `arrival_date`) VALUES
('1101', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1102', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1103', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1104', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1105', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1201', 'ณัฐชนน สินเจริญเลิศ', '0851632706', '3 มกราคม 2543', 'คณะศึกษาศาสตร์', '5', '435/8 ต.หมากแข้ง อ.เมือง จ.อุดรธานี 41000', 'วชิรภรณ์', '0856155952', '25 สิงหาคม 2565'),
('1202', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1203', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1204', '-', '-', '-', '-', '-', '-', '-', '-', '-'),
('1205', '-', '-', '-', '-', '-', '-', '-', '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `roomlist`
--

CREATE TABLE `roomlist` (
  `room` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `how` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `roomlist`
--

INSERT INTO `roomlist` (`room`, `status`, `how`) VALUES
('1101', 'ไม่ว่าง', 'มีผู้อยู่อาศัย'),
('1102', 'ว่าง', ''),
('1103', 'ว่าง', ''),
('1104', 'ว่าง', ''),
('1105', 'ว่าง', ''),
('1201', 'ไม่ว่าง', 'มีผู้อยู่อาศัย'),
('1202', 'ว่าง', ''),
('1203', 'ว่าง', ''),
('1204', 'ว่าง', ''),
('1205', 'ไม่ว่าง', 'ปูกระเบื้องใหม่');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `id` int(11) NOT NULL,
  `room` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `maintenaceservice` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `time` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `allow` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`id`, `room`, `maintenaceservice`, `time`, `status`, `allow`, `timestamp`) VALUES
(1, '1103', 'เก้าอี้หัก', '22 มิถุนายน 2565', 'ดำเนินการเข้าซ่อมเรียบร้อยแล้ว', 'นัดตามวัน', '2022-06-25 12:01:58'),
(2, '1201', 'เก้าอี้หัก', '22 มิถุนายน 2565', 'ดำเนินการเข้าซ่อมเรียบร้อยแล้ว', 'เข้าทำได้เลย', '2022-06-25 12:01:58'),
(3, '1104', 'หลอดไฟกลางห้องขาด', '14 มิถุนายน 2565', 'ดำเนินการเข้าซ่อมเรียบร้อยแล้ว', 'เข้าทำได้เลย', '2022-06-25 12:01:58'),
(4, '1104', 'หลอดไฟในห้องน้ำขาด', '29 กรกฎาคม 2565', 'รอเข้าซ่อม', 'นัดตามวัน', '2022-06-25 12:01:58'),
(5, '1103', 'ก๊อกอ่างล้างหน้าหลวม', '12 สิงหาคม 2565', 'รอเข้าซ่อม', 'เข้าทำได้เลย', '2022-06-25 12:01:58'),
(6, '1101', 'มีน้ำซึมตรงอ่างล้างหน้า', '15 กรกฎาคม 2565', 'รอเข้าซ่อม', 'เข้าทำได้เลย', '2022-06-30 12:28:16'),
(7, '1101', 'เครื่องทำน้ำอุ่นไม่ทำงาน', '14 กรกฎาคม 2565', 'ดำเนินการเข้าซ่อมเรียบร้อยแล้ว', 'นัดตามวัน', '2022-07-21 08:40:48'),
(8, '1201', 'ไฟซ็อต', '9 กรกฎาคม 2565', 'ดำเนินการเข้าซ่อมเรียบร้อยแล้ว', 'เข้าทำได้เลย', '2022-06-30 14:49:40'),
(9, '1201', 'หลอดไฟขาด', '3 สิงหาคม 2565', 'รอเข้าซ่อม', 'นัดตามวัน', '2022-08-03 07:53:55'),
(10, '1201', 'หลอดไฟกลางห้องขาด', '25 สิงหาคม 2565', 'ดำเนินการเข้าซ่อมเรียบร้อยแล้ว', 'เข้าทำได้เลย', '2022-08-25 16:24:16');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `room` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `note` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `status`, `room`, `note`) VALUES
('1111', '1111', 'user', '1104', 1),
('123456', '123456', 'user', '1104', 2),
('bonus1', '224466', 'user', '1205', 3),
('Bonusu', '282546', 'admin', '', 4),
('Testz', '123456', 'user', '1102', 6),
('Username', 'Password', 'user', '1105', 7),
('wizleee', '290999', 'user', '1101', 8),
('wizone', '112233', 'user', '1202', 9),
('1111', '1111', 'user', '1101', 10),
('wizone', '112233', 'user', '1103', 11),
('testtest', 'testtest', 'user', '1205', 12),
('Yenavirus', '290999', 'user', '1101', 13),
('Maple', '12345678m', 'user', '1201', 14);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rentalfee`
--
ALTER TABLE `rentalfee`
  ADD PRIMARY KEY (`room`);

--
-- Indexes for table `residents_name`
--
ALTER TABLE `residents_name`
  ADD PRIMARY KEY (`room`);

--
-- Indexes for table `roomlist`
--
ALTER TABLE `roomlist`
  ADD PRIMARY KEY (`room`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`note`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `service`
--
ALTER TABLE `service`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `note` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
