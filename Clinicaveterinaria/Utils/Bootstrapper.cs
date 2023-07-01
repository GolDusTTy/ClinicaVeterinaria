using Arquivos.Models;
using Arquivos.Data;

namespace Arquivos.Utils
{
    public class Bootstrapper
    {

        public static void Charger()
        {
            ChargeClients();
            ChargeAnimals();
            ChargeDoctors();
            ChargeClinics();
        }

        public static void ChargeClients()
        {
            DataSet.Clients.Add(
                new Client{
                    Id = 1,
                    FirstName = "Maicon",
                    LastName = "Felipe",
                    CPF = "000.000.000.00",
                    Email = "maiconfelipe@gmail.com"
                }
            );

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "João",
                    LastName = "Pedro",
                    CPF = "000.000.000.01",
                    Email = "joãopedro23@hotmail.com"
                }
            );

            DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Matheus",
                    LastName = "Henrique",
                    CPF = "000.000.000.02",
                    Email = "matheushenrique2000@gmail.com"
                }
            );
            
        }

        public static void ChargeAnimals()
        {
            DataSet.Animals.Add(
                new Animal{
                    Id = 1,
                    Name = "Jose",
                    Sexo = "Macho",
                    Tipo = "Papagaio"
                }
            );

            DataSet.Animals.Add(
                new Animal{
                    Id = 2,
                    Name = "Bob",
                    Sexo = "Macho",
                    Tipo = "Cachorro"
                }
            );

            DataSet.Animals.Add(
                new Animal{
                    Id = 3,
                    Name = "Nana",
                    Sexo = "Femea",
                    Tipo = "Macaco"
                }
            );
            
        }

        public static void ChargeDoctors()
        {
            DataSet.Doctors.Add(
                new Doctor{
                    Id = 1,
                    FirstName = "Lucas",
                    LastName = "Almeida",
                    CPF = "000.000.000.00",
                    Email = "nessacucavaicenoura@gmail.com",
                    ClinicName = "ClinicaDavidaAnimal"
                }
            );

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 2,
                    FirstName = "Anna",
                    LastName = "Banana",
                    CPF = "000.000.000.01",
                    Email = "Anabemdoida26@gmail.com",
                    ClinicName = "ViralataPetShop"
                }
            );

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 3,
                    FirstName = "Matheus",
                    LastName = "Henrique",
                    CPF = "000.000.000.02",
                    Email = "matheushenrique2000@gmail.com",
                    ClinicName = "CausAnimal"
                }
            );
            
        }
        public static void ChargeClinics()
        {
            DataSet.Clinics.Add(
                new Clinic{
                    Id = 1,
                    Name = "ClinicaDavidaAnimal",
                    Telefone = "(48)98470-6515",
                    Endereco = "Florianopolis SC, Av.Renato Algusto Centro, 96"
                }
            );

            DataSet.Clinics.Add(
                new Clinic{
                    Id = 2,
                    Name = "ViralataPetShop e clinica",
                    Telefone = "(49)12876-5412",
                    Endereco = "Chapeco, R. Logo Ali, 2000"
                }
            );

            DataSet.Clinics.Add(
                new Clinic{
                    Id = 3,
                    Name = "CausAnimal",
                    Telefone = "(12)41265-7897",
                    Endereco = "Brasilia, Av.Naquele lugar, 675"
                }
            );
            
        }
    }
}