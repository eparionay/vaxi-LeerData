create table Curso(
		CursoId int primary key identity(1,1),
		Titulo nvarchar(500),
		Descripcion nvarchar(100),
		FechaPublicacion datetime,
		FotoPortada varbinary(max)
)
go

  create table Precio (
	PrecioId int primary key identity(1,1),
	PrecioActual money,
	Promocion money,
	CursoId int
  )
  go

  alter table Precio
  add constraint fk_precio_curso foreign key (CursoId) references Curso
  go

  create table Comentario(
	ComentarioId int primary key identity(1,1),
	Alumno nvarchar(500),
	Puntaje int,
	ComentarioTexto nvarchar(max),
	CursoId int
  )
  go

  alter table Comentario
  add constraint fk_comentario_curso foreign key(CursoId)
  references Curso
  go

  select * from Comentario
  go


  create table Instructor
  (
	InstructorId int primary key identity(1,1),
	Nombre nvarchar(100),
	Apellidos nvarchar(100),
	Grado nvarchar(20),
	FotoPerfil varbinary(max)
  )
  go


  create table CursoInstructor
  (
	CursoId int not null,
	InstructorId int not null
  )
  go


  alter table CursoInstructor
  add constraint pk_cursoinstructor
  primary key (CursoId, InstructorId)
  go

  alter table CursoInstructor
  add constraint fk_instructor_curso
  foreign key (CursoId)
  references Curso(CursoId)
  go

  alter table CursoInstructor
  add constraint fk_instructor_instructor
  foreign key (InstructorId)
  references Instructor(InstructorId)
  go

















