using Net5.R.InfraAlu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.R.InfraAlu.Data.Contexts
{
    public static class LibraryContextExtensions
    {
        public static void EnsureSeeDataForContext(this LibraryContext context)
        {
            context.Alumnos.RemoveRange(context.Alumnos);
            context.SaveChanges();

            List<Alumnos> alumnoss = new List<Alumnos>() {
                new Alumnos()
                {
                    AlumnosId = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                    FirstName = "Enrique",
                    LastName = "Puerto",
                    DateOfBirth = new DateTimeOffset(new DateTime(1995, 12, 9)),
                    Specialty="Ingeniería Sistemas",
                    Courses = new List<course>()
                    {
                        new course()
                        {
                            courseId = new Guid("c7ba6add-09c4-45f8-8dd0-eaca221e5d93"),
                            courseName = "Sistemas y Métodos",
                            Description = "Esta materia propone los recursos para el estudio y control de Organizaciones abordando: Teoría general de sistemas. La organización. La Dirección. La planificación y el control. El proceso administrativo. El enfoque sistémico. La administración de proyectos. Los sistemas de información. El desarrollo de un sistema de información. Las herramientas. Relaciones Laborales."
                        },
                        new course()
                        {
                            courseId = new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"),
                            courseName = "Análisis Matemático I",
                            Description = "Conjuntos numéricos. Intervalos reales. Funciones Reales. Función inversa. Funciones polinómicas, racionales, exponenciales, logarítmicas. Funciones trigonométricas. Dominios. Gráficas. Demostraciones Formales. Argumentos válidos y no válidos. Tipos de argumentos. Método directo. Demostración por contradicción.Predicados y su valor de verdad. Inducción matemática.Concepto de Límite. Límites finitos e infinitos. Continuidad. Asíntotas. Derivada de una función en un punto. Función derivada. Derivadas sucesivas. Cálculo de derivadas. Recta tangente y normal. Aplicación: Regla de L’Hospital."
                        },
                        new course()
                        {
                            courseId = new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"),
                            courseName = "Sistemas Digitales I",
                            Description = "En esta materia se abordan los conceptos para analizar y diseñar circuitos. Álgebra de Boole y compuertas lógicas. Teoremas y leyes principales. Representaciones canónicas. Tablas de verdad. Mapas de Karnaugh. Circuitos lógicos y sistemas digitales. Lógica de interruptores. Lógica de compuertas. Aritmética digital. Tipos de Circuitos Sistemas parcialmente definidos. Tiempos de propagación. Cargas. Riesgos. Redundancias. Hardware digital. Introducción a los dispositivos lógicos programables. Realimentación de circuitos lógicos. Distintos tipos. Registros. Tablas de transiciones. Máquinas de estado. Autómatas de Mealy y Moore. Estados equivalentes. Reducción de estados. Máquinas algorítmicas. Procesadores de alta prestación. Conceptos de arquitecturas reconfigurables. Conceptos de arquitecturas basadas en servicios."
                        },
                        new course()
                        {
                            courseId = new Guid("60188a2b-2784-4fc4-8df8-8919ff838b0b"),
                            courseName = "Sistemas Operativos",
                            Description = "El curso aborda los conceptos de los mecanismos de Sistemas Operativos sus procesos, memoria y manejo de archivos.Introducción a los sistemas operativos. Administración de procesos. Planificación de procesos. Administración de recursos compartidos, sincronización, comunicación entre procesos. Abrazo mortal (deadlock, inter bloqueo o bloqueo mutuo). Administración de memoria. Memoria virtual. Administración de dispositivos de entrada-salida. Administración de archivos. Protección. Introducción a los sistemas distribuidos."
                        }
                    }
                },
                new Alumnos()
                {
                     AlumnosId = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                     FirstName = "Juan Luis",
                     LastName = "Moro",
                     DateOfBirth = new DateTimeOffset(new DateTime(1995, 1, 30)),
                     Specialty="Ingeniería Sistemas",
                     Courses = new List<course>()
                     {
                         new course()
                         {
                             courseId = new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"),
                             courseName = "Sistemas Digitales I",
                             Description = "En esta materia se abordan los conceptos para analizar y diseñar circuitos. Álgebra de Boole y compuertas lógicas. Teoremas y leyes principales. Representaciones canónicas. Tablas de verdad. Mapas de Karnaugh. Circuitos lógicos y sistemas digitales. Lógica de interruptores. Lógica de compuertas. Aritmética digital. Tipos de Circuitos Sistemas parcialmente definidos. Tiempos de propagación. Cargas. Riesgos. Redundancias. Hardware digital. Introducción a los dispositivos lógicos programables. Realimentación de circuitos lógicos. Distintos tipos. Registros. Tablas de transiciones. Máquinas de estado. Autómatas de Mealy y Moore. Estados equivalentes. Reducción de estados. Máquinas algorítmicas. Procesadores de alta prestación. Conceptos de arquitecturas reconfigurables. Conceptos de arquitecturas basadas en servicios."
                        },
                         new course()
                         {
                             courseId = new Guid("bc4c35c3-3857-4250-9449-155fcf5109ec"),
                             courseName = "Física I",
                             Description = "Mediciones. Errores. Vectores. Operaciones básicas con vectores. Magnitudes escalares y vectoriales. Estática. Cinemática. Movimiento rectilíneo. Aceleración. Caída libre. Tiro vertical. Dinámica. Leyes de Newton. Fuerzas. Fuerzas centrífuga y centrípeta. Trabajo. Potencia. Energía cinética y energía potencial. Ley de conservación de la energía mecánica. Impulso y cantidad de movimiento. Gravitación."
                         },
                         new course()
                         {
                             courseId = new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239"),
                             courseName = "Análisis Matemático II",
                             Description = "Aplicaciones de la derivada: Extremos locales, puntos de inflexión. Integración. La integral indefinida. La integral definida. Aplicaciones: cálculo de áreas. La integral impropia. Funciones de varias variables. Límite, continuidad. Derivadas parciales. Derivadas direccionales. Extremos locales. Extremos condicionados."
                         }
                     }
                },
                new Alumnos()
                {
                     AlumnosId = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"),
                     FirstName = "Alfonso",
                     LastName = "Parra",
                     DateOfBirth = new DateTimeOffset(new DateTime(1994, 9, 27)),
                     Specialty="Ingeniería Sistemas",
                     Courses = new List<course>()
                     {
                         new course()
                         {
                             courseId = new Guid("9edf91ee-ab77-4521-a402-5f188bc0c577"),
                             courseName = "Base de Datos",
                             Description = "La asignatura introduce a los alumnos en el concepto de diseño y gestión de Datos. Objetivos de los Sistemas de Bases de Datos. Sistemas de Gestión de Base de Datos. Modelos: conceptos básicos; principios de abstracción. Modelo relacional. Modelo Entidad-Relación. Anomalías y peligros en el diseño de bases de datos relacionales. Lenguajes de Consulta: SQL."
                         }
                     }
                },
                new Alumnos()
                {
                     AlumnosId = new Guid("578359b7-1967-41d6-8b87-64ab7605587e"),
                     FirstName = "Hamid",
                     LastName = "Simone",
                     DateOfBirth = new DateTimeOffset(new DateTime(1994, 5, 14)),
                     Specialty="Ingeniería Sistemas",
                     Courses = new List<course>()
                     {
                         new course()
                         {
                             courseId = new Guid("01457142-358f-495f-aafa-fb23de3d67e9"),
                             courseName = "Análisis Matemático II",
                             Description = "Aplicaciones de la derivada: Extremos locales, puntos de inflexión. Integración. La integral indefinida. La integral definida. Aplicaciones: cálculo de áreas. La integral impropia. Funciones de varias variables. Límite, continuidad. Derivadas parciales. Derivadas direccionales. Extremos locales. Extremos condicionados."
                         }
                     }
                },
                new Alumnos()
                {
                     AlumnosId = new Guid("f74d6899-9ed2-4137-9876-66b070553f8f"),
                     FirstName = "Nicolas",
                     LastName = "Cabello",
                     DateOfBirth = new DateTimeOffset(new DateTime(1996, 4, 17)),
                     Specialty="Ingeniería Sistemas",
                     Courses = new List<course>()
                     {
                         new course()
                         {
                             courseId = new Guid("e57b605f-8b3c-4089-b672-6ce9e6d6c23f"),
                             courseName = "Sistemas Digitales I",
                             Description = "En esta materia se abordan los conceptos para analizar y diseñar circuitos. Álgebra de Boole y compuertas lógicas. Teoremas y leyes principales. Representaciones canónicas. Tablas de verdad. Mapas de Karnaugh. Circuitos lógicos y sistemas digitales. Lógica de interruptores. Lógica de compuertas. Aritmética digital. Tipos de Circuitos Sistemas parcialmente definidos. Tiempos de propagación. Cargas. Riesgos. Redundancias. Hardware digital. Introducción a los dispositivos lógicos programables. Realimentación de circuitos lógicos. Distintos tipos. Registros. Tablas de transiciones. Máquinas de estado. Autómatas de Mealy y Moore. Estados equivalentes. Reducción de estados. Máquinas algorítmicas. Procesadores de alta prestación. Conceptos de arquitecturas reconfigurables. Conceptos de arquitecturas basadas en servicios."
                        }
                     }
                },
                new Alumnos()
                {
                     AlumnosId = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                     FirstName = "Eduard",
                     LastName = "Pereira",
                     DateOfBirth = new DateTimeOffset(new DateTime(1996, 4, 17)),
                     Specialty="Ingeniería Sistemas",
                     Courses = new List<course>()
                     {
                         new course()
                         {
                             courseId = new Guid("1325360c-8253-473a-a20f-55c269c20407"),
                             courseName = "Estructura de Datos y Algoritmos",
                             Description = "El propósito de esta materia es trabajar con distintas estructuras de datos: Resolución de Problemas y Algoritmos. Estructuras de datos. Arreglos - Clasificación de arreglos. Ordenamiento. Recursividad. Caracteres. Algoritmos de búsqueda. Estructura de Lista. Estructura Pila. Estructura cola. Estructura de árbol. Operaciones. Algoritmos fundamentales: recorridos, búsquedas, ordenamiento, actualización. Tipos abstractos. Archivos. Manejo de memoria."
                         }
                     }
                }
            };

            context.Alumnos.AddRange(alumnoss);
            context.SaveChanges();

        }
    }
}
