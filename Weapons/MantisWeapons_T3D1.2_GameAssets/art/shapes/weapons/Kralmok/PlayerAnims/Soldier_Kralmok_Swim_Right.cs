singleton TSShapeConstructor(Soldier_Kralmok_Swim_RightDAE)
{
   baseShape = "./Soldier_Kralmok_Swim_Right.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1630", "1689", true, true);
}
