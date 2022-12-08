-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: dymshop
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `CategoryID` int NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(100) NOT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Жидкости для электронных сигарет'),(2,'Электронные сигареты'),(3,'Кальяны'),(4,'Табак для кальяна'),(5,'Уголь'),(6,'Картриджи'),(7,'Одноразовые электронные сигареты');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderproduct`
--

DROP TABLE IF EXISTS `orderproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderproduct` (
  `OrderNumber` int NOT NULL,
  `ProductArticle` varchar(6) NOT NULL,
  `ProductCount` int NOT NULL,
  PRIMARY KEY (`OrderNumber`,`ProductArticle`),
  KEY `ProductArticle` (`ProductArticle`),
  CONSTRAINT `orderproduct_ibfk_1` FOREIGN KEY (`OrderNumber`) REFERENCES `orders` (`OrderNumber`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `orderproduct_ibfk_2` FOREIGN KEY (`ProductArticle`) REFERENCES `products` (`Article`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderproduct`
--

LOCK TABLES `orderproduct` WRITE;
/*!40000 ALTER TABLE `orderproduct` DISABLE KEYS */;
INSERT INTO `orderproduct` VALUES (1,'BR2117',2),(1,'BR2119',1),(2,'CR23WN',1),(4,'BR2119',23),(4,'BR2122',3),(5,'BR2114',10),(5,'BR2118',1),(5,'BR2119',1),(5,'JSG512',1),(5,'K121LL',4),(5,'KA4124',1),(6,'BR2113',1),(6,'BR2114',1),(7,'BR2115',2),(7,'BR2118',5),(8,'BR2117',2),(9,'BR2114',12),(10,'BR2112',12),(10,'BR2113',1),(10,'BR2114',1),(10,'BR2116',1);
/*!40000 ALTER TABLE `orderproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderNumber` int NOT NULL AUTO_INCREMENT,
  `OrderDateStart` date DEFAULT NULL,
  `OrderDateDelivery` date DEFAULT NULL,
  `OrderPickPoint` int DEFAULT NULL,
  `OrderBuyer` int NOT NULL,
  `OrderCode` int DEFAULT NULL,
  `OrderStatus` varchar(150) NOT NULL,
  PRIMARY KEY (`OrderNumber`),
  KEY `OrderBuyer` (`OrderBuyer`),
  KEY `OrderPickPoint` (`OrderPickPoint`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`OrderPickPoint`) REFERENCES `pickuppoint` (`PointID`),
  CONSTRAINT `user_orders` FOREIGN KEY (`OrderBuyer`) REFERENCES `users` (`UserId`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2014-09-20','2014-09-20',2,1,123,'Завершён'),(2,'2022-09-12','2022-09-12',2,2,511,'Завершён'),(3,'2022-12-01',NULL,NULL,4,NULL,'Завершён'),(4,'2022-12-01','2022-12-04',5,33,965031,'Активный'),(5,'2022-12-07','2022-12-10',3,6,618312,'Активный'),(6,'2022-12-07','2022-12-10',5,10,341537,'Активный'),(7,'2022-12-07','2022-12-10',4,10,493682,'Активный'),(8,'2022-12-07','2022-12-10',5,10,883991,'Активный'),(9,'2022-12-07','2022-12-10',2,1,564511,'Активный'),(10,'2022-12-07','2022-12-10',1,1,494939,'Активный');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pickuppoint`
--

DROP TABLE IF EXISTS `pickuppoint`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pickuppoint` (
  `PointID` int NOT NULL,
  `PointIndex` varchar(6) NOT NULL,
  `City` varchar(150) NOT NULL,
  `Street` varchar(150) NOT NULL,
  `TownNumber` int NOT NULL,
  PRIMARY KEY (`PointID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pickuppoint`
--

LOCK TABLES `pickuppoint` WRITE;
/*!40000 ALTER TABLE `pickuppoint` DISABLE KEYS */;
INSERT INTO `pickuppoint` VALUES (1,'432520','Уфа','Менделеева',134),(2,'410252','Уфа','Комсомольская',15),(3,'412412','Уфа','Садовая',10),(4,'412515','Уфа','Максима Рыльского',8),(5,'412412','Уфа','Батырская',41);
/*!40000 ALTER TABLE `pickuppoint` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `Article` varchar(6) NOT NULL,
  `ProductName` varchar(150) NOT NULL,
  `ProductCategory` int NOT NULL,
  `ProductPhoto` varchar(150) DEFAULT NULL,
  `ProductCost` int NOT NULL,
  `ProductDiscount` int NOT NULL,
  `ProductCountInStock` int NOT NULL,
  `ProductDescription` varchar(255) NOT NULL,
  `ProductSupplier` int DEFAULT NULL,
  PRIMARY KEY (`Article`),
  KEY `ProductCategory` (`ProductCategory`),
  KEY `ProductSupplier` (`ProductSupplier`),
  CONSTRAINT `products_ibfk_1` FOREIGN KEY (`ProductCategory`) REFERENCES `categories` (`CategoryID`),
  CONSTRAINT `products_ibfk_2` FOREIGN KEY (`ProductSupplier`) REFERENCES `suppliers` (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES ('BR2112','Brusko Feelin Mini',2,'Brusko13.jpg',1090,10,26,'ЭС BRUSKO FEELIN MINI, 750 MAH, БЕЖЕВО-РОЗОВЫЙ ГРАДИЕНТ',1),('BR2113','Brusko Go',7,'Brusko14.jpg',450,0,20,'ОДНОРАЗОВАЯ ЭС BRUSKO GO, ДО 800 ЗАТЯЖЕК, ЛЕДЯНЫЕ ФРУКТЫ, 20 МГ/МЛ',1),('BR2114','Brusko Go',7,'Brusko15.jpg',450,0,22,'ОДНОРАЗОВАЯ ЭС BRUSKO GO, ДО 800 ЗАТЯЖЕК, МАНГО, 20 МГ/МЛ',1),('BR2115','Brusko Go',7,'Brusko16.jpg',450,0,20,'ОДНОРАЗОВАЯ ЭС BRUSKO GO, ДО 800 ЗАТЯЖЕК, СИНЯЯ МАЛИНА, 20 МГ/МЛ',1),('BR2116','Brusko Go',7,'Brusko17.jpg',650,0,20,'ОДНОРАЗОВАЯ ЭС BRUSKO GO MAX, ДО 1500 ЗАТЯЖЕК, КЛУБНИКА СО СЛИВКАМИ, 20 МГ/МЛ',1),('BR2117','Brusko Go',7,'Brusko18.jpg',890,0,20,'ОДНОРАЗОВАЯ ЭС BRUSKO GO GIGA, ДО 3000 ЗАТЯЖЕК, ЛЕДЯНОЙ АРБУЗ, 20 МГ/МЛ',1),('BR2118','Brusko Flexus Stik',2,'Brusko19.jpg',1590,10,20,'ЭС BRUSKO FLEXUS STIK, 1200 MAH, ФУКСИЯ',1),('BR2119','Уголь Brusko',5,'Ugli1.jpg',650,0,20,'УГОЛЬ ДЛЯ КАЛЬЯНА КОКОСОВЫЙ BRUSKO, КУБИК 25 ММ, 1 УП (72 ШТ)',1),('BR2120','Brusko Minican Картридж',6,'Kart1.jpg',250,0,20,'СМЕННЫЙ КАРТРИДЖ BRUSKO MINICAN, 3.0 МЛ, 1.0 ОМ, ЧЕРНЫЙ, 1ШТ, (В УПАК. 2 ШТ)',1),('BR2121','Brusko Minican Картридж',6,'Kart3.jpg',250,0,20,'СМЕННЫЙ КАРТРИДЖ BRUSKO MINICAN, 3.0 МЛ, 1.0 ОМ, ПРОЗРАЧНЫЙ, 1ШТ, (В УПАК. 2 ШТ)',1),('BR2122','Brusko Minican Картридж',6,'Kart4.jpg',290,0,20,'ПРЕДЗАПРАВЛЕННЫЙ КАРТРИДЖ BRUSKO MINICAN PREFILLED PODS, 2,4 МЛ, ЯБЛОКО СО ЛЬДОМ, 20 МГ/МЛ, 1 ШТ.',1),('COCO12','Уголь Coconara',5,'Ugli2.jpg',650,10,40,'УГОЛЬ ДЛЯ КАЛЬЯНА КОКОСОВЫЙ COCONARA, КУБИК 25 ММ, 1 УП (72 ШТ)',2),('CR23WN','Уголь Crown',5,'Ugli4.jpg',200,0,20,'УГОЛЬ ДЛЯ КАЛЬЯНА КОКОСОВЫЙ CROWN, КУБИК 22 ММ, 1УП (24ШТ)',3),('E323GR','Смесь Brusko',4,'Brusko6.jpg',150,0,10,'БЕСТАБАЧНАЯ СМЕСЬ ДЛЯ КАЛЬЯНА BRUSKO, 50 Г, ЛИМОН С МЕЛИССОЙ, MEDIUM',1),('EF122F','Жидкость Brusko',1,'Brusko2.jpg',350,15,10,'ЖИДКОСТЬ BRUSKO, 60 МЛ, МЕЛИССА С МЯТОЙ (BREEZINESS), 0 МГ/МЛ',1),('FACO31','Уголь Fanconi',5,'Ugli3.jpg',650,20,100,'УГОЛЬ ДЛЯ КАЛЬЯНА КОКОСОВЫЙ FANCONI, КУБИК 22 ММ, 1УП (96ШТ)',4),('FL23FL','Brusko One',2,'Brusko9.jpg',890,10,20,'ЭС BRUSKO ONE, 500 MAH, ЧЕРНЫЙ*',1),('G88GGE','Brusko Minican',2,'Brusko10.jpg',1190,5,20,'ЭС BRUSKO MINICAN, 350 MAH, БЕЛЫЙ',1),('H908JJ','Табак Brusko',4,'Brusko7.jpg',190,0,10,'ТАБАК ДЛЯ КАЛЬЯНА BRUSKO, С АРОМАТОМ АПЕЛЬСИНА, 25 Г.',1),('IH3222','inHale Kan Hard',7,'inHale.jpg',650,15,30,'ОДНОРАЗОВАЯ ЭС INHALE KAN HARD, ДО 1800 ЗАТЯЖЕК, GUMMY CANDY (ЖЕВАТЕЛЬНЫЕ КОНФЕТЫ), 2 МГ/МЛ',5),('JJ323E','Жидкость Mishka',1,'Mishka1.jpg',490,0,12,'ЖИДКОСТЬ МИШКА, 120 МЛ, ЯБЛОКО-ЭНЕРГЕТИК, 0 МГ/МЛ*',6),('JS124S','Картридж JustFog',6,'Kart2.jpg',200,0,10,'СМЕННЫЙ КАРТРИДЖ JUSTFOG MINIFIT, 1,5 МЛ, 1.6 ОМ, 1 ШТ, (В УПАК. 3 ШТ)',7),('JSG512','Brusko Minican Plus',2,'Brusko12.jpg',1590,10,21,'ЭС BRUSKO MINICAN PLUS, 850 MAH, ЖЁЛТЫЙ',1),('K121LL','Смесь Brusko',4,'Brusko4.jpg',150,0,10,'БЕСТАБАЧНАЯ СМЕСЬ ДЛЯ КАЛЬЯНА BRUSKO, 50 Г, МУЛЬТИФРУКТ, MEDIUM',1),('K323LF','Жидкость Brusko',1,'Brusko3.jpg',350,15,9,'ЖИДКОСТЬ BRUSKO, 60 МЛ, ГРАНАТ С КИВИ (WELLNESS), 0 МГ/МЛ',1),('KA4124','Кальян KiDish',3,'Kalian1.jpg',4490,0,10,'КАЛЬЯН BLACK, 75 СМ',8),('L23SSS','Жидкость Batareykin',1,'Batareykin1.jpg',350,10,9,'ЖИДКОСТЬ BATAREYKIN, 120 МЛ, FOREST BERRIES MIX, 0 МГ/МЛ*',9),('L3200L','Жидкость Boshki',1,'Boshki1.jpg',490,20,12,'ЖИДКОСТЬ BOSHKI, 100 МЛ, ЭКЗОТИК, 3 МГ/МЛ',10),('MYA234','Кальян MYA',3,'Kalian3.jpg',4990,10,30,'КАЛЬЯН MYA, СЕРЕБРЯНЫЙ, 58 СМ',11),('NEF21K','Смесь Brusko',4,'Brusko5.jpg',150,0,10,'БЕСТАБАЧНАЯ СМЕСЬ ДЛЯ КАЛЬЯНА BRUSKO, 50 Г, СИБИРСКИЙ ЛИМОНАД, MEDIUM',1),('NL2141','Кальян NeoLux',3,'Kalian2.jpg',3100,20,20,'КАЛЬЯН NEO LUX V2L, ЧЕРНЫЙ',12),('O239OS','Табак Brusko',4,'Brusko8.jpg',190,0,10,'ТАБАК ДЛЯ КАЛЬЯНА BRUSKO, С АРОМАТОМ БАНАНА, 25 Г.',1),('RN2142','Rincoe Mantoe',2,'RincoeMAIO.jpg',2390,10,40,'ЭС RINCOE MANTO AIO POD KIT, 80W, 18650, RAIJIN',13),('SSS999','Brusko Favostix',2,'Brusko11.jpg',2190,10,19,'ЭС BRUSKO FAVOSTIX, 1000 MAH, ЧЕРНЫЙ',1),('VA1244','Картридж Vaporesso',6,'Kart5.jpg',300,0,20,'СМЕННЫЙ КАРТРИДЖ VAPORESSO XROS, 2 МЛ, 1,2 ОМ, 1 ШТ, (В УПАК. 2 ШТ)',14),('VA1245','Картридж Vaporesso',6,'Kart6.jpg',350,0,20,'СМЕННЫЙ КАРТРИДЖ VAPORESSO XTRA MESHED UNIPOD, 2 МЛ, 0.8 ОМ, 1 ШТ, (В УПАК. 2 ШТ)',14),('VA1246','Картридж Vaporesso',6,'Kart7.jpg',360,0,10,'СМЕННЫЙ КАРТРИДЖ VAPORESSO LUXE Q, 2 МЛ, 1,2 ОМ, 1 ШТ, (В УПАК. 2 ШТ)',14),('А112Т4','Жидкость Brusko',1,'Brusko1.jpg',350,15,9,'Жидкость Brusko, 60 мл, Ягодный десерт (Goodness), 0 мг/мл',1);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `Role_ID` int NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(100) NOT NULL,
  PRIMARY KEY (`Role_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Гость'),(2,'Покупатель'),(3,'Продавец'),(4,'Администратор');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `SupplierID` int NOT NULL AUTO_INCREMENT,
  `SupplierName` varchar(150) NOT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Brusko'),(2,'Coconara'),(3,'Crown'),(4,'Fanconi'),(5,'inHale'),(6,'Mishka'),(7,'JustFog'),(8,'KiDish'),(9,'Batareykin'),(10,'Boshki'),(11,'MYA'),(12,'NeoLux'),(13,'Rincoe Mantoe'),(14,'Vaporesso');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(100) NOT NULL,
  `UserSurname` varchar(100) NOT NULL,
  `UserPatronymic` varchar(100) NOT NULL,
  `PhoneNumber` varchar(18) NOT NULL,
  `UserRole` int NOT NULL,
  `UserBirthday` date DEFAULT NULL,
  `UserEmail` varchar(100) DEFAULT NULL,
  `UserLogin` varchar(45) NOT NULL,
  `UserPassword` varchar(45) NOT NULL,
  `UserAdress` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`UserId`),
  KEY `role_users_idx` (`UserRole`),
  CONSTRAINT `roleusers` FOREIGN KEY (`UserRole`) REFERENCES `roles` (`Role_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Вероника','Яркаева','Андреевна','89563856373',2,NULL,'qwerty.com','o@outlook','2L6KZG',NULL),(2,'Глеб','Федоров','Михайлович','89563856372',2,NULL,'asdfgh.com','fgnbdlfjkv','3L6KZG',NULL),(3,'Софья','Семенова','Дмитриевна','89563856371',2,NULL,'hr6zdl@yandex.ru','hr6zdl@ya','uzWC67',NULL),(4,'Егор','Васильев','Германович','89563856370',2,NULL,'kaft93x@outlook.com','kaft9outl','8ntwUp',NULL),(5,'Ирина','Смирнова','Александровна','89563856374',2,NULL,'dcu@yandex.ru','dcu@yuj','YOyhfR',NULL),(6,'Андрей','Петров','Владимирович','89563856300',2,NULL,'19dn@outlook.com','RSbvHv23456','RSbvHv',NULL),(7,'Максим','Егоров','Андреевич','89563856311',2,NULL,'pa5h@mail.ru','rwVDh9dfghj','rwVDh9',NULL),(8,'Артур','Никитин','Алексеевич','89563856333',2,NULL,'281av0@gmail.com','LdNyosdfghjk','LdNyos',NULL),(9,'Максим','Киселев','Сергеевич','89563856344',2,NULL,'8edmfh@outlook.com','gynQMT5hdwf','gynQMT',NULL),(10,'Тимур','Борисов','Егорович','89362736471',2,NULL,'sfn13i@mail.ru','AtnDjrpnjdn','AtnDjr',NULL),(11,'Арсений','Климов','Тимурович','89362736472',2,NULL,'g0orc3x1@outlook.com','JlFRCZhifr','JlFRCZ',NULL),(12,'Василиса','Колпакова','Романовна','8971648912364',2,NULL,'7vnrat4hmcz6@yahoo.com','8ntwUpkllj','8ntwUp',NULL),(13,'Анастасия','Шубина','Вячеславовна','89016489231',2,NULL,'v4mlcsi1bgnk@tutanota.com','YOyhfR7i','YOyhfR',NULL),(14,'Арина','Мартынова','Михайловна','89016489237',2,NULL,'2yx3tbqv4ndi@outlook.com','RSbvHvfa4t','RSbvHv',NULL),(15,'Ариана','Евдокимова','Михайловна','89016489232',2,NULL,'p7rviz42j6bh@outlook.com','LdNyos0ii','LdNyos',NULL),(16,'Алиса','Климова','Александровна','89567532146',2,NULL,'g5nrmh1axwfl@outlook.com','gynQMT9ifA','gynQMT',NULL),(17,'Владислав','Куликов','Даниилович','+7 (987) 887-12-31',2,NULL,'5knb4drlf2hj@tutanota.com','AtnDjrooj','AtnDjr',''),(18,'Диана','Сакаева','Флоридовна','+7 (987) 785-12-31',4,'2005-01-20','','loginDEmgl2018','QJNgD&','Максима Рыльского 21'),(19,'Кирилл','Быков','Павлович','+7 (987) 133-12-31',4,'2026-06-20','','loginDEtms2018','70Z&Zy','Кирова 65'),(20,'Вячеслав','Герасимов ','Ростиславович','+7 (987) 228-12-31',3,'2020-09-20','','loginDEyix2018','6zbXg*','Бикбая 5'),(21,'Всеволод','Суворов ','Богданович','+7 (987) 990-12-31',3,'2009-08-20','','loginDEhuv2018','EJFYzS','Комсомольская 15'),(22,'Антон','Шестаков ','Константинович','+7 (987) 555-12-31',3,'2001-01-20','','loginDEyat2018','ELSTyH','Проспект Октября 90'),(23,'Федосей','Игнатьев ','Богданович','+7 (987) 444-12-31',3,'2005-04-20','','loginDEmin2018','pQ6jze','Революционная 4'),(24,'Лев','Алексеев','Матвеевич','+7 (987) 623-13-11',3,'2017-07-20','','loginDElmy2018','X2LtuP','Житомирская 12'),(25,'Донат','Беляев ','Агафонович','+7 (987) 111-12-31',3,'2012-06-20','','loginDEyct2018','uD+|Ud','Менделеева 134'),(26,'Аделя','Исхакова','Фанзилевна','+7 (987) 723-13-12',4,'2023-03-20','','loginDEmrj2018','blrD&8','Гагарина 22'),(27,'Сабина','Сабирова','Ильнаровна','+7 (987) 615-12-31',4,'2027-02-20','','loginDEjvp2018','etLGcB','Зорге 4'),(33,'Николай','Толстой','Толстопузович','+7 (987) 623-12-31',2,NULL,'tolst@gmail.com','lololoshka228','oilpoil',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-07 21:30:43
