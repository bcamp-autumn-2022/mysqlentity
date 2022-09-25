CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `identity` int DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

INSERT INTO `user` VALUES (1,'user01','pass1',1,'Lisa','Admin1'),(2,'user02','pass2',2,'Bob','Student1'),(3,'user4','$2a$11$FqU8KxB4if.DfXufHOYsUO35q2CRFvPNmopfAcBBu3pKKC5pT3MnS',3,'Ann','Teacher1'),(5,'user05','$2a$11$5bANriWpp9cFkxYiP93MiOttJp1Jel0AVXVzlPLzagiEVuNGzNdhi',2,'Jussi','Testi'),(9,'user07','$2a$11$dWh2.AIe13ymslkZRS.wc.oE8RzhKFFN/o4Szt9vqzHlCVYLykjRS',3,'Matti','Mainio');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
