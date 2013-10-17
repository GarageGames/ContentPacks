singleton TSShapeConstructor(Soldier_Kraad_Death2DAE)
{
   baseShape = "./Soldier_Kraad_Death2.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Death2DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death2", "1210", "1255", true, true);
}
