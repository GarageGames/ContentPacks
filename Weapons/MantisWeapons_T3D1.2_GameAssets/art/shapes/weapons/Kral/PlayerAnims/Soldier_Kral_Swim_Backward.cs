singleton TSShapeConstructor(Soldier_Kral_Swim_BackwardDAE)
{
   baseShape = "./Soldier_Kral_Swim_Backward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Swim_BackwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Backward", "1600", "1659", true, true);
}
