using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary
{
    /*
     * Implementierung des Interfaces. Hier werden die Methoden erstellt,
     * welche es ermöglichen Daten speichern (Update, Delete, Insert) und laden (Select) zu können.
     */
    public class DataAccess : IDataAccess
    {
        // Für Select mit mehreren Zeilen Ergebnissen: übergibt eine SQL Query und Parameter an die MySQL Connection und erwartet eine Liste von Ergebnissen
        // Der Listen-Rückgabetyp wird beim Methoden Aufruf definiert (<T>)
        // Die Parameterdefinition (dynamisches SQL) wird beim Methodenaufruf definiert (<U>)
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        // Für Select mit einer einzigen Zeile als Ergebnis: übergibt eine SQL Query und Parameter an die MySQL Connection und erwartet eine einzige Zeile
        // Der Rückgabetyp wird beim Methoden Aufruf definiert (<T>)
        // Die Parameterdefinition (dynamisches SQL) wird beim Methodenaufruf definiert (<U>)
        public async Task<T> LoadSingleRow<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.FirstOrDefault();
            }
        }

        // Für Update, Insert und Delete: übergibt eine SQL Query und Parameter an die MySQL Connection und führt damit eine Aktion aus
        // (Update, Insert, Delete bzw. Befehle die keinen Rückgabewert erwarten)
        // Die Parameterdefinition (dynamisches SQL) wird beim Methodenaufruf definiert (<T>) 
        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}