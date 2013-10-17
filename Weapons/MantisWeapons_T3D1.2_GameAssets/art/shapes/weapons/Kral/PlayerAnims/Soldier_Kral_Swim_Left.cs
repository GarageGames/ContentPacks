singleton TSShapeConstructor(Soldier_Kral_Swim_LeftDAE)
{
   baseShape = "./Soldier_Kral_Swim_Left.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1690", "1749", true, true);
}
