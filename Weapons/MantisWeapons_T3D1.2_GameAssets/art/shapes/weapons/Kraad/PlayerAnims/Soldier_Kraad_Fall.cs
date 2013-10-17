singleton TSShapeConstructor(Soldier_Kraad_FallDAE)
{
   baseShape = "./Soldier_Kraad_Fall.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "1040", "1069", true, true);
}
