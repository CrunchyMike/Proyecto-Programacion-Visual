CREATE TABLE productos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    categoria VARCHAR(50),
    precio DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL DEFAULT 0
);

CREATE TABLE artistas (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre_artistico VARCHAR(100) NOT NULL,
    edad INT,
    genero VARCHAR(50),
    especialidad VARCHAR(100),
    salario_base DECIMAL(10, 2) NOT NULL,
    activo BOOLEAN NOT NULL DEFAULT 0
);

select * from artistas;
select * from productos;