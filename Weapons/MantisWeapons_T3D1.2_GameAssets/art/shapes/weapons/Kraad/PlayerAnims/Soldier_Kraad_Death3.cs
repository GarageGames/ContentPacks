singleton TSShapeConstructor(Soldier_Kraad_Death3DAE)
{
   baseShape = "./Soldier_Kraad_Death3.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Death3DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death3", "1280", "1320", true, true);
}
