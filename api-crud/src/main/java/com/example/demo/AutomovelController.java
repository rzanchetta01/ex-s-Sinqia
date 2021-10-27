package com.example.demo;

import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import java.util.List;

@RestController
public class AutomovelController {
	
	AutomovelRepository repository;
	

	public AutomovelController(AutomovelRepository repository) {
		this.repository = repository;
	}
	
	@GetMapping("/automovel")
	public List<Automovel> getAllAutomoveis() {
		return repository.findAll();
	}
	
	@GetMapping("/automovel/{id}")
	public Automovel getAutomovelById(@PathVariable Long id) {
		return repository.findById(id).get();
	}

	@PostMapping("/automovel")
	public Automovel insertAutomovel(@RequestBody Automovel automovel) {
		return repository.save(automovel);
	}
	
	@DeleteMapping("/automovel/{id}")
	public void deleteAutomovel(@PathVariable Long id) {
		repository.deleteById(id);
	}
	
	@PutMapping("/automovel/{id}")
	public void updateAutomovel(@PathVariable Long id, @RequestBody Automovel automovel) {
		repository.save(automovel);
	}
}
