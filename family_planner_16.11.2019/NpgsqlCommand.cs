using System;

namespace family_planner_16._11._2019
{

    //String v - could there be used more describing name?
    internal class NpgsqlCommand
    {
        private string v;
        private NpgsqlConnection conn;

        public NpgsqlCommand(string v, NpgsqlConnection conn)
        {
            this.v = v;
            this.conn = conn;
        }

        internal NpgsqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}