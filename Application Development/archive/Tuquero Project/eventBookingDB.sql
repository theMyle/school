/*
SQLyog Community v13.3.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - eventbookingdb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`eventbookingdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `eventbookingdb`;

/*Table structure for table `bookings` */

DROP TABLE IF EXISTS `bookings`;

CREATE TABLE `bookings` (
  `booking_id` int(11) NOT NULL AUTO_INCREMENT,
  `booking_date_time` datetime DEFAULT current_timestamp(),
  `customer_name` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `contact_number` varchar(15) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`booking_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20005 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `bookings` */

insert  into `bookings`(`booking_id`,`booking_date_time`,`customer_name`,`address`,`contact_number`,`email`) values 
(20000,'2024-12-18 17:27:09','Jodet M.','Roro','123456789','roro@gmail.com'),
(20001,'2024-12-18 21:02:34','a','a','a','a'),
(20003,'2024-12-19 09:59:32','Prince Aaron','Sorsogon City','09123456789','Aaron@gmail.com'),
(20004,'2024-12-19 10:12:13','Gerald Montana','Sorsogon City','09123456789','GM@gmail.com');

/*Table structure for table `event_type` */

DROP TABLE IF EXISTS `event_type`;

CREATE TABLE `event_type` (
  `event_id` int(11) NOT NULL,
  `event_type` varchar(50) NOT NULL,
  PRIMARY KEY (`event_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `event_type` */

insert  into `event_type`(`event_id`,`event_type`) values 
(1001,'Birthday'),
(1002,'Birthday'),
(1003,'Conference'),
(1004,'Seminar'),
(1005,'Anniversary'),
(1006,'Workshop'),
(1007,'Baby Shower'),
(1008,'Christmas Party'),
(1009,'Reunion'),
(1010,'Religious Gathering');

/*Table structure for table `events` */

DROP TABLE IF EXISTS `events`;

CREATE TABLE `events` (
  `booking_pk` int(11) NOT NULL AUTO_INCREMENT,
  `event_id` int(11) DEFAULT NULL,
  `booking_id` int(11) DEFAULT NULL,
  `event_name` varchar(100) NOT NULL,
  `description` varchar(254) DEFAULT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  `status` enum('Upcoming','Ongoing','Cancelled','Done') NOT NULL,
  `number_guests` int(11) DEFAULT NULL,
  PRIMARY KEY (`booking_pk`),
  KEY `booking_id` (`booking_id`),
  KEY `event_id` (`event_id`),
  CONSTRAINT `events_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `event_type` (`event_id`),
  CONSTRAINT `events_ibfk_2` FOREIGN KEY (`booking_id`) REFERENCES `bookings` (`booking_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `events` */

insert  into `events`(`booking_pk`,`event_id`,`booking_id`,`event_name`,`description`,`start_date`,`end_date`,`status`,`number_guests`) values 
(2,1002,20000,'Party 2','Swinnming!','2024-12-21 06:30:00','2024-12-17 17:27:02','Upcoming',150),
(3,1001,20003,'Prince Bday','Birthday Party','2024-12-19 06:30:54','0000-00-00 00:00:00','Ongoing',50),
(4,1001,20004,'Swimming Party','Swimsuit Party','2024-12-28 18:30:54','0000-00-00 00:00:00','Upcoming',100);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `user_id` int(10) NOT NULL,
  `user_name` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `role` varchar(50) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `users` */

insert  into `users`(`user_id`,`user_name`,`password`,`fullname`,`email`,`role`) values 
(1,'Aaron','admin','Aaron Tuquero','tuqueroaaron@gmail.com','CEO'),
(2,'John','employee','John Doe','johndoe@edu.com','employee');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
