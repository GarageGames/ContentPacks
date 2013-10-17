singleton TSShapeConstructor(Soldier_Kral_Swim_RightDAE)
{
   baseShape = "./Soldier_Kral_Swim_Right.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1780", "1839", true, true);
}
