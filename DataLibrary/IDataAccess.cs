using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    // Interface, das festlegt welche Aktionen, für Datenbank Zugriffe möglich sein sollen.
    public interface IDataAccess
    {
        // Für Select mit mehreren Zeilen Ergebnissen: übergibt eine SQL Query und Parameter an die MySQL Connection und erwartet eine Liste von Ergebnissen
        // Der Listen-Rückgabetyp wird beim Methoden Aufruf definiert (<T>)
        // Die Parameterdefinition (dynamisches SQL) wird beim Methodenaufruf definiert (<U>)
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);

        // Für Select mit einer einzigen Zeile als Ergebnis: übergibt eine SQL Query und Parameter an die MySQL Connection und erwartet eine einzige Zeile
        // Der Rückgabetyp wird beim Methoden Aufruf definiert (<T>)
        // Die Parameterdefinition (dynamisches SQL) wird beim Methodenaufruf definiert (<U>)
        Task<T> LoadSingleRow<T, U>(string sql, U parameters, string connectionString);

        // Für Update, Insert und Delete: übergibt eine SQL Query und Parameter an die MySQL Connection und führt damit eine Aktion aus
        // (Update, Insert, Delete bzw. Befehle die keinen Rückgabewert erwarten)
        // Die Parameterdefinition (dynamisches SQL) wird beim Methodenaufruf definiert (<T>) 
        Task SaveData<T>(string sql, T parameters, string connectionString);
    }
}