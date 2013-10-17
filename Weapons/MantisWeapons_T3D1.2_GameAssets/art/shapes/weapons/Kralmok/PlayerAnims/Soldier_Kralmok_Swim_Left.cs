singleton TSShapeConstructor(Soldier_Kralmok_Swim_LeftDAE)
{
   baseShape = "./Soldier_Kralmok_Swim_Left.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1540", "1599", true, true);
}
