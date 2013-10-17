singleton TSShapeConstructor(Soldier_Kraad_Swim_LeftDAE)
{
   baseShape = "./Soldier_Kraad_Swim_Left.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1670", "1729", true, true);
}
