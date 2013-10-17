singleton TSShapeConstructor(Soldier_Kraad_RunDAE)
{
   baseShape = "./Soldier_Kraad_Run.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "150", "169", true, true);
}
