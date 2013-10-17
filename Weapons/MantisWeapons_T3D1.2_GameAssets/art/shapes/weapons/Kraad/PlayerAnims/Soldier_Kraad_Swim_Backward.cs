singleton TSShapeConstructor(Soldier_Kraad_Swim_BackwardDAE)
{
   baseShape = "./Soldier_Kraad_Swim_Backward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Swim_BackwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Backward", "1580", "1639", true, true);
}
