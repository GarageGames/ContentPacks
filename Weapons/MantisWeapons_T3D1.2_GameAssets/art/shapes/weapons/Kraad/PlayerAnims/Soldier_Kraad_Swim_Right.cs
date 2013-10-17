singleton TSShapeConstructor(Soldier_Kraad_Swim_RightDAE)
{
   baseShape = "./Soldier_Kraad_Swim_Right.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1760", "1820", true, true);
}
