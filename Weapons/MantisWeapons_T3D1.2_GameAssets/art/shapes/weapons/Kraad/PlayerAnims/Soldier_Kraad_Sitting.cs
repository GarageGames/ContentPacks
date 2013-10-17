singleton TSShapeConstructor(Soldier_Kraad_SittingDAE)
{
   baseShape = "./Soldier_Kraad_Sitting.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_SittingDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sitting", "1360", "1365", true, true);
}
