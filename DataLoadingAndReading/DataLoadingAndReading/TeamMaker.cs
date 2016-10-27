using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoadingAndReading
{
    class TeamMaker
    {
        DataManager dataHandler = new DataManager();

        int teamSize;
        int numberOfTeams;
        double maxScore = 0;
        double cumulativeTeamScores = 0;
        string[] data;
        //List<Member> classList = new List<Member>();
        List<Team> teams = new List<Team>();
        Team classList = new Team();

        //loaddata from each file that starts with last name
        public void loadClass(string dataFile)
        {
            //given a file with a class list
            data = dataHandler.readAllData(dataFile);
            //read the class list in
            foreach (string s in data)
            {
                classList.members.Add(new Member(s.Split(',')));
            }
            //for each name in the class list
            foreach (Member m in classList.members)
            {
                data = dataHandler.readAllData(m.name[0] + m.name[1]+".txt");
                //read the class list in and load with their selections
                foreach (string s in data)
                {
                    string[] temp = s.Split(',');
                    string[] t = new string[] { temp[0], temp[1] };
                    //add weightings based on the order (1/n?)
                    m.classMates.Add(new Member(t, 1/m.classMates.Count));
                   
                }
            }

        }

        public double attemptTeams(double lastScore)
        {
            //try to the highest rankings into separate groups
            //place next randomly until out of people


            return 0;
        }

        //for a large number of attempts
            //calculate the collective score
            //if its higher than the previous high 
                //then accept this set of teams
            
            
            

    }

    class Team
    {
        //team has members
        public List<Member> members;
        //team has a overall score
        double score;

        public Team(){
            members = new List<Member>();
            score = 0;
        }

        //team can calc its score
        public double calcTeamScore(){
            foreach (Member m in members)
            {
                score += m.calcValue();
            }
            return score;
        }
    }

    class Member
    {
        //members belong to a team
        public Team team;
        
        //has a first name
        //has a second name
        public string[] name;
      
        //has a weighting value 
        public double value;
        public double teamValue = 0;
            //used to store the total of the weightings of team mates

        //every member has an array list of other members with weightings
        public List <Member> classMates = new List<Member>();

        public Member(Team t, string[] n, List <Member> m)
        {
            team = t;
            name = n;
            classMates = m;
        }

        public Member(string[] n)
        {
            name = n;
         }

        public Member(string[] n, double d)
        {
            name = n;
            value = d;

        }

        public Member(string[] n,List <Member> m)
        {
            team = null;
            name = n;
            classMates = m;
        }

        public void setClassList(List<Member> m)
        {
            classMates = m;
        }

        public void setTeam(Team t)
        {
            team = t;
        }

        public void setValue(string s)
        {
            value = Double.Parse(s);
        }


        public double calcValue()
        {

            foreach (Member m in team.members)
            {
                foreach (Member c in classMates)
                {
                    if (m == c)
                    {
                        teamValue += c.value;
                    }
                }
            }
            return teamValue;
        }
    }

}
