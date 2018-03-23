using Chapter20.CustomerMaintenance.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Chapter20.CustomerMaintenance.Database
{
    public class StatesDbo : IStatesDbo
    {
        public IList<State> GetStates()
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            var selectStatement =
                "SELECT StateCode, StateName " +
                "FROM States";
            var selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                var stateReader = selectCommand.ExecuteReader();
                if(stateReader.HasRows)
                {
                    List<State> states = new List<State>();
                    while(stateReader.Read())
                    {
                        var state = new State();
                        state.StateCode = stateReader["StateCode"].ToString();
                        state.StateName = stateReader["StateName"].ToString();
                        states.Add(state);
                    }
                    
                    return states;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException se)
            {
                throw se;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
