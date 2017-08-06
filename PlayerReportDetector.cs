#region System Namespace
using System;
using System.Linq;
using System.IO;
#endregion System Namespace

#region Foreign Namespace
#endregion Foreign Namespace

#region Styx Namespace

using System.Threading;
using Bots.DungeonBuddy.Helpers;
using Styx;
using Styx.Plugins;
using Styx.Common;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;

#endregion Styx Namespace

namespace PlayerReportsDetector
{
    public class PlayerReportsDetector : HBPlugin
    {
        public override string Name { get { return "PlayerReportsDetector"; } }
        public override string Author { get { return "Giwin"; } }
        public override Version Version { get { return new Version(1, 3); } }
        public override bool WantButton { get { return true; } }
        public string FileLocation = @"Plugins\PlayerReportsDetector\" + StyxWoW.Me.RealmName + @"\" + StyxWoW.Me.Name + ".txt";

		public virtual void OnEnable()
        {
            CreateFile();
            Logging.Write("PlayerReportsDetectors - Loaded Version " + Version);
        }

        public override void OnButtonPress()
        {
            new Form1().ShowDialog();
        }

        public void CreateFile()
        {
            if (!Directory.Exists(@"Plugins\PlayerReportsDetector\" + StyxWoW.Me.RealmName))
            {
                Directory.CreateDirectory(@"Plugins\PlayerReportsDetector\" + StyxWoW.Me.RealmName);
                Thread.Sleep(2000);
                if (!File.Exists(FileLocation))
                    File.Create(FileLocation);
            }
            else if (!File.Exists(FileLocation))
                File.Create(FileLocation);
        }

        public override void Pulse()
        {
            if (!StyxWoW.IsInGame) return;
            if (!StyxWoW.Me.IsAlive) return;
            if (Player() == null || IsPlayerInList(Player().Name)) return;
            WriteToFile(Player());
        }

        public bool IsPlayerInList(string name)
        {
            try
            {
                using (var streamReader = new StreamReader(FileLocation))
                {
                    var s = streamReader.ReadToEnd();
                    return s.Contains(name);
                }
            }
            catch (Exception e)
            {
                Logging.Write(Name + " " + e.Message + Environment.NewLine + e.InnerException);
            }
            return false;
        }

        public WoWPlayer Player()
        {
            var playerList =
                ObjectManager.GetObjectsOfType<WoWPlayer>(false, false).Where(
                    o => o != null && o.CurrentTarget != null && o.CurrentTarget.IsMe);
            return playerList.FirstOrDefault();
        }
        public void WriteToFile(WoWPlayer player)
        {
            try
            {
                using (var streamWriter = new StreamWriter(FileLocation, true))
                {
                    streamWriter.WriteLineAsync(player.Name + "|" +
                                                player.Level + "|" +
                                                DateTime.Now + "|" +
                                                player.FactionGroup + "|" +
                                                player.Location + "|" +
                                                StyxWoW.Me.Location + "|" +
                                                player.Distance + "|" +
                                                player.Mounted + "|" +
                                                StyxWoW.Me.IsSwimming + "|" +
                                                new ScriptHelpers.NoUnstuck().IsStuck() + "|" +
                                                StyxWoW.Me.Combat + "|" +
                                                StyxWoW.Me.IsInInstance + "|");
                }
            }
            catch (Exception e)
            {
                Logging.Write(Name + " " + e.Message + Environment.NewLine + e.InnerException);
            }
        }
    }
}