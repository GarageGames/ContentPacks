singleton TSShapeConstructor(Soldier_Kral_Crouch_SideDAE)
{
   baseShape = "./Soldier_Kral_Crouch_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "510", "539", true, true);
}
