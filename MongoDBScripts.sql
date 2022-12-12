use LibreriaMongoDB

db.createCollection('Autor')

db.Autor.insertMany([{
    'nombre': 'Jose',
    'apellido': 'Velasquez',
    'gradoAcademico': 'Ingeniero de Software'
},
{
    'nombre': 'Daniel',
    'apellido': 'Hernandez',
    'gradoAcademico': 'Ingeniero de Sistemas'
},
{
    'nombre': 'Carlos',
    'apellido': 'Velasquez',
    'gradoAcademico': 'Ingeniero Ferroviario'
}]
)